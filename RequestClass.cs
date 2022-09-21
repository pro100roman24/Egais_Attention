using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Egais_Attention
{
	[XmlRoot(ElementName = "departmentIds")]
	public class DepartmentIds
	{

		[XmlElement(ElementName = "i")]
		public string I { get; set; }

		[XmlAttribute(AttributeName = "cls")]
		public string Cls { get; set; }

		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "args")]
	public class Args
	{

		[XmlElement(ElementName = "client-type")]
		public string Clienttype { get; set; }

		[XmlElement(ElementName = "enable-warnings")]
		public bool Enablewarnings { get; set; }

		[XmlElement(ElementName = "request-watchdog-check-results")]
		public bool Requestwatchdogcheckresults { get; set; }

		[XmlElement(ElementName = "use-raw-entities")]
		public bool Userawentities { get; set; }

		[XmlElement(ElementName = "dateFrom")]
		public string DateFrom { get; set; }

		[XmlElement(ElementName = "dateTo")]
		public string DateTo { get; set; }

		[XmlElement(ElementName = "includeDeleted")]
		public bool IncludeDeleted { get; set; }

		public static Args Default
		{
			get
			{
				return new Args() { Clienttype = "BACK", Enablewarnings = true, Userawentities = true,
					DateFrom = (DateTime.Now.Date - TimeSpan.FromDays(8)).ToString("O"), DateTo = DateTime.Now.AddDays(2).Date.ToString("O"), IncludeDeleted = true, Requestwatchdogcheckresults = true };
			}
		}
	}
}
