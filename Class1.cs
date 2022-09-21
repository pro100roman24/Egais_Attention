using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egais_Attention
{
    public class EgaisInvoice
    {
        public string Number { get; set; }
        public string TTN { get; set; }
        public string Supplier { get; set; }
        public DateTime DateIncoming { get; set; }
        public bool confirmtofront { get; set; }

    }
}
