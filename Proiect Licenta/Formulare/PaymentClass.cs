using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Licenta.Formulare
{
    public partial  class PaymentClass
    {
        public Guid ID;
        public int CardNumber { get; set; }
        public int CVV { get; set; }
        public DateTime Exp { get; set; }
        public string CardHolder { get; set; }

        public PaymentClass()
        {
            ID = new Guid();
        }

    }
}
