using Resto.Front.Api;
using Resto.Front.Api.Attributes;
using Resto.Front.Api.Attributes.JetBrains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using Lemma_Lic;
using Resto.Front.Api.UI;
using Resto.Front.Api.Extensions;
using System.Xml.Serialization;
using System.IO;
using Serialization;
using Leaf.xNet;
using System.Reactive.Disposables;

namespace Egais_Attention
{
    [UsedImplicitly]
    [PluginLicenseModuleId(21039501)]

    public sealed class Front_Plugin : IFrontPlugin
    {

        private readonly CompositeDisposable subscriptions;
        public Front_Plugin()
        {
            Plugin.Log_Mess_Warn("Плагин {0} запускается.", Plugin.Name);
            // Lemma.CheckLicense(PluginContext.Operations.GetHostRestaurant().IikoUid, Plugin.Name);

            subscriptions = new CompositeDisposable
            {
                PluginContext.Notifications.CafeSessionClosing.Subscribe(x => CafeSessionClosing(x.vm)),
                PluginContext.Notifications.CafeSessionOpening.Subscribe(x => CafeSessionOpening(x.vm))
            };

            var URI = Config.Instance.iikoServerURI;

            //try
            //{
            //    EgaisCheck();
            //}
            //catch
            //{
            //    EgaisCheck();
            //}

            //PluginContext.Notifications.NavigatingToPaymentScreen.Subscribe(x => nav(x.order, x.os, x.vm));
            Plugin.Log_Mess_Info("Плагин {0} успешно запущен.", Plugin.Name);
            var order = PluginContext.Operations.GetOrders(false, true);

            // createguest();



        }

        bool SendOpen = false;
        bool SendClose = false;

        private void CafeSessionOpening(IViewManager vm)
        {
            try
            {
                if (!SendOpen)
                {
                    PluginContext.Log.Info("Открытие кассовой смены, проверим накладные");
                    var Request = new HttpRequest();
                    var text = " 🌝 Открытие кассовой смены 🌝";
                    Request.Get($"https://api.telegram.org/bot5532356935:AAETmeOPcQwshoq-XUX46FpVo1OEiJazxQo/sendMessage?chat_id={Config.Instance.Chat_id}&text=" + text);
                    List<EgaisInvoice> checkresult = new List<EgaisInvoice>();
                    try
                    {
                        checkresult = EgaisCheck();
                    }
                    catch
                    {
                        checkresult = EgaisCheck();
                    }
                    string message = "В системе обнаружены не подтвержденные накладные ЕГАИС!";

                    var testdate = DateTime.Now.Date;

                    if (checkresult.Any(x => !x.confirmtofront && x.DateIncoming.Date <= DateTime.Now.Date))
                    {
                        PluginContext.Log.Info("Найдены неподтвержденные накладные");
                        var i = 1;
                        foreach (var item in checkresult.Where(x => !x.confirmtofront && x.DateIncoming.Date <= DateTime.Now.Date)) //&& x.DateIncoming.Date >= DateTime.Now.Date
                        {
                            message += $"\n {i}) Накладная {item.Number}\n от {item.Supplier}\n Дата отгрузки: {item.DateIncoming.Date.ToString("d")}\n {item.TTN}";
                        }

                        message += "\n Настоятельно рекомендуется подтвердить накладные сразу после открытия кассовой смены";
                        message += "\n Факт неподтверждения накладных будет донесен до руководства.";
                        vm.ShowOkPopup("ВНИМАНИЕ!", message);
                    }
                    SendOpen = true;
                    SendClose = false;
                }
            }
            catch (Exception ex)
            {
                PluginContext.Log.Error(ex.Message + ex.StackTrace);
            }
            
        }

        private void CafeSessionClosing(IViewManager vm)
        {
            try
            {
                if (!SendClose)
                {
                    PluginContext.Log.Info("Закрытие кассовой смены, проверим накладные");
                    var Request = new HttpRequest();
                    var text = " 🌚 Закрытие кассовой смены 🌚";
                    Request.Get($"https://api.telegram.org/bot5532356935:AAETmeOPcQwshoq-XUX46FpVo1OEiJazxQo/sendMessage?chat_id={Config.Instance.Chat_id}&text=" + text);
                    List<EgaisInvoice> checkresult = new List<EgaisInvoice>();
                    try
                    {
                        checkresult = EgaisCheck();
                    }
                    catch
                    {
                        checkresult = EgaisCheck();
                    }

                    string message = "В системе обнаружены не подтвержденные накладные ЕГАИС!";

                    var testdate = DateTime.Now.Date;

                    if (checkresult.Any(x => !x.confirmtofront && x.DateIncoming.Date <= DateTime.Now.Date))
                    {
                        PluginContext.Log.Info("Найдены неподтвержденные накладные");
                        var i = 1;
                        foreach (var item in checkresult.Where(x => !x.confirmtofront && x.DateIncoming.Date <= DateTime.Now.Date)) //&& x.DateIncoming.Date >= DateTime.Now.Date
                        {
                            message += $"\n {i}) Накладная {item.Number}\n от {item.Supplier}\n Дата отгрузки: {item.DateIncoming.Date.ToString("d")}\n {item.TTN}";
                        }
                        message += "\n Настоятельно рекомендуется выйти из мастера закрытия кассовой смены, подтвердить накладные, затем вернуться к закрытию смены.";
                        message += "\n Факт неподтверждения накладных будет донесен до руководства.";
                        vm.ShowOkPopup("ВНИМАНИЕ!", message);
                    }
                    SendClose = true;
                    SendOpen = false;
                }
            }
            catch (Exception ex)
            {
                PluginContext.Log.Error(ex.Message + ex.StackTrace);
            }
            
        }

        public static List<EgaisInvoice> EgaisCheck()
        {

            var body = Serialize(Args.Default);

            var Request = new HttpRequest();

            var Param = new RequestParams();
            Param.Add(new KeyValuePair<string, string>("methodName", "getEgaisDocuments"));

            //Request.AddHeader("Content-Type", "application/xml");
            Request.AddHeader("X-Resto-LoginName", Config.Instance.UserLogin);
            Request.AddHeader("X-Resto-PasswordHash", Config.Instance.PasswordHash);
            Request.AddHeader("X-Resto-BackVersion", "7.9.7013.0");
            Request.AddHeader("X-Resto-AuthType", "BACK");
            Request.AddHeader("X-Resto-ServerEdition", "IIKO_RMS");
            Request.AddHeader("Accept-Language", "ru");
            //var Response = Request.Post("http://26.217.197.116:8080/resto/services/egaisDocuments?methodName=getEgaisDocuments", body, "application/xml").ToString();

            PluginContext.Log.Info($"Отправляем запрос на получение накладных { Config.Instance.iikoServerURI}/ services/egaisDocuments?methodName=getEgaisDocuments");

            var Response = Request.Post($"{Config.Instance.iikoServerURI}/services/egaisDocuments?methodName=getEgaisDocuments", body, "application/xml").ToString();

            var egaislist = new Xml2CSharp.Result();

            List<EgaisInvoice> egaisInvoices = new List<EgaisInvoice>();

            XmlSerializer serializer = new XmlSerializer(typeof(Xml2CSharp.Result));
            using (StringReader reader = new StringReader(Response))
            {
                egaislist = (Xml2CSharp.Result)serializer.Deserialize(reader);
            }

            foreach (var Invoice in egaislist.ReturnValue.I.Where(x => x.Cls == "EgaisIncomingInvoice" && x.ConfirmStatus != "CONFIRMED")) // && x.ConfirmStatus != "CONFIRMED"
            {
                var i = 0;
                foreach (var item in Invoice.Items.I.Where(x => x.MarksNotConfirmed.Null == "1" || x.MarksNotConfirmed.I.Count > 0))
                {
                    i++;
                }

                if (i > 0)
                {
                    egaisInvoices.Add(new EgaisInvoice()
                    {
                        Number = Invoice.WbNumber,
                        TTN = Invoice.WbRegId,
                        Supplier = Invoice.ShipperInfo.FullName,
                        DateIncoming = Invoice.ShippingDate,
                        confirmtofront = false
                    });
                }
                else
                {
                    egaisInvoices.Add(new EgaisInvoice()
                    {
                        Number = Invoice.WbNumber,
                        TTN = Invoice.WbRegId,
                        Supplier = Invoice.ShipperInfo.FullName,
                        DateIncoming = Invoice.ShippingDate,
                        confirmtofront = true
                    });
                }
            }

            Request = new HttpRequest();

            if (egaisInvoices.Count > 0)
            {
                var i = 1;
                if (egaisInvoices.Any(x => !x.confirmtofront))
                {
                    var text = " 🚛 Внимание❗️ Обнаружены не подтвержденные накладные ЕГАИС! 📦🧾";
                    Request.Get($"https://api.telegram.org/bot5532356935:AAETmeOPcQwshoq-XUX46FpVo1OEiJazxQo/sendMessage?chat_id={Config.Instance.Chat_id}&text=" + text);

                    foreach (var item in egaisInvoices.Where(x => !x.confirmtofront))
                    {
                        string num = Number(i);
                        TimeSpan DaysConfirm = item.DateIncoming.AddDays(3).Date - DateTime.Now.Date;

                        if (DaysConfirm.TotalDays >= 3)
                        {
                            text = $"{num}\n 🟢  Накладная {item.Number}\n от {item.Supplier}\n Дата отгрузки: {item.DateIncoming.Date.ToString("d")}\n {item.TTN}  🟢";

                            text += $"\nОсталось дней для подтверждения: {DaysConfirm.TotalDays}";
                            Response = Request.Get($"https://api.telegram.org/bot5532356935:AAETmeOPcQwshoq-XUX46FpVo1OEiJazxQo/sendMessage?chat_id={Config.Instance.Chat_id}&text=" + text).ToString();

                        }
                        else if (DaysConfirm.TotalDays == 2)
                        {
                            text = $"{num}\n 🟠  Накладная {item.Number}\n от {item.Supplier}\n Дата отгрузки: {item.DateIncoming.Date.ToString("d")}\n {item.TTN}  🟠 ";

                            text += $"\nОсталось дней для подтверждения: {DaysConfirm.TotalDays}";
                            Response = Request.Get($"https://api.telegram.org/bot5532356935:AAETmeOPcQwshoq-XUX46FpVo1OEiJazxQo/sendMessage?chat_id={Config.Instance.Chat_id}&text=" + text).ToString();
                        }
                        else if (DaysConfirm.TotalDays <= 1)
                        {
                            text = $"{num}\n 🛑⛔️🆘  Накладная {item.Number}\n от {item.Supplier}\n Дата отгрузки: {item.DateIncoming.Date.ToString("d")}\n {item.TTN}  🛑⛔️🆘 ";

                            text += $"\n❗❗❗ Нужно срочно подтвердить ❗❗❗";
                            Response = Request.Get($"https://api.telegram.org/bot5532356935:AAETmeOPcQwshoq-XUX46FpVo1OEiJazxQo/sendMessage?chat_id={Config.Instance.Chat_id}&text=" + text).ToString();
                            
                        }
                        i++;
                    }
                }

                i = 1;
                if (egaisInvoices.Any(x => x.confirmtofront))
                {
                   var text = " ✅ Внимание❗️ Обнаружены ПОДТВЕРЖДЕННЫЕ накладные ЕГАИС! 📦🧾";
                    Request.Get($"https://api.telegram.org/bot5532356935:AAETmeOPcQwshoq-XUX46FpVo1OEiJazxQo/sendMessage?chat_id={Config.Instance.Chat_id}&text=" + text);

                    foreach (var item in egaisInvoices.Where(x => x.confirmtofront))
                    {
                        string num = Number(i);
                        text = $"{num}\n ✅  Накладная {item.Number}\n от {item.Supplier}\n Дата отгрузки: {item.DateIncoming.Date.ToString("d")}\n {item.TTN}  ✅";
                        text += $"\n ✅ ПОДТВЕРЖДЕНА В iikoFront ✅";
                        text += $"\n Необходимо подтвердить накладную в iikoOffice❗️";
                        Response = Request.Get($"https://api.telegram.org/bot5532356935:AAETmeOPcQwshoq-XUX46FpVo1OEiJazxQo/sendMessage?chat_id={Config.Instance.Chat_id}&text=" + text).ToString();
                        i++;

                    }
                }
            }

            return egaisInvoices;
        }

        public static string Number(int num)
        {
            string j = num.ToString();
            string res = "";
            for (int i = 0; i < j.Length; i++)
            {
                res += j[i] + "⃣";
            }
            return res;
        }

        public static string Serialize<TObject>(TObject @object)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(@object.GetType());
            var xns = new XmlSerializerNamespaces();
            xns.Add(string.Empty, string.Empty);

            using (StringWriter textWriter = new Utf8StringWriter())
            {
                xmlSerializer.Serialize(textWriter, @object, xns);
                return textWriter.ToString();
            }
        }

        private void nav(Resto.Front.Api.Data.Orders.IOrder order, IOperationService os, IViewManager vm)
        {
            try
            {
                os.AddOrderExternalData("bms", "testdata", false, os.GetOrderById(order.Id), os.GetCredentials());
                var text = PluginContext.Operations.TryGetOrderExternalDataByKey(order, "bms");
            }
            catch (Exception ex)
            {

                throw;
            }


        }

        public void Dispose()
        {
            while (subscriptions.Any())
            {
                try
                {
                    subscriptions?.Dispose();
                }
                catch (RemotingException)
                {
                    // nothing to do with the lost connection
                }
            }
            Plugin.Log_Mess_Info("Плагин {0} успешно остановлен.", Plugin.Name);
        }
    }
}
