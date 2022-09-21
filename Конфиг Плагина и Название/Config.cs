using Resto.Front.Api;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Egais_Attention
{


    public sealed class Config
    {

        #region Допы
        private const string ConfigFileName = Plugin.Name + "_Config.xml";
        private static string FilePath
        {
            get { return Path.GetFullPath(Path.Combine(PluginContext.Integration.GetConfigsDirectoryPath(), ConfigFileName)); }
        }
        private static Config instance;
        #endregion
        /// <summary>
        /// Перечисляем параметры и значения по умолчанию, если конфиг уже был создан, он перезапишется,
        /// если параметра нет то используется значение по умолчанию
        /// </summary>
       
        public string iikoServerURI { get; set; }
        public string Chat_id { get; set; }
        public string UserLogin { get; set; }
        public string PasswordHash { get; set; }


        public Config() // Значения по умолчанию Если нет конфига
        {
            iikoServerURI = "https://host.iiko.it/resto";
            Chat_id = "-656521350";
            UserLogin = "Loginiiko";
            PasswordHash = "хеш пароля пользователя iikoOffice в sha1";
        }

        public static Config Instance
        {
            get
            {
                return instance ?? (instance = Load());
            }
        }
        private static Config Load()
        {
            var config = new Config();
            try
            {
                PluginContext.Log.InfoFormat("Загрузка настроек плагина из {0}", FilePath);
                using (var stream = new FileStream(FilePath, FileMode.Open))

                using (var reader = new StreamReader(stream))
                {
                    config = (Config)new XmlSerializer(typeof(Config)).Deserialize(reader);
                }
                config.Save();
                return config;
            }
            catch (Exception e)
            {
                PluginContext.Log.Error("Не удалось загрузить настройки плагина. Используются настройки по умолчанию.");
            }
            config.Save();
            return config;
        }
        private void Save()
        {
            try
            {
                PluginContext.Log.InfoFormat("Сохранение настроек плагина в {0}", FilePath);
                using (Stream stream = new FileStream(FilePath, FileMode.Create))
                {
                    new XmlSerializer(typeof(Config)).Serialize(stream, this);
                }
            }
            catch (Exception e)
            {
                PluginContext.Log.Error("Ошибка сохранение настроек плагина: ", e);
            }
        }

    }

}
