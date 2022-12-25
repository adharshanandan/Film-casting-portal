using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Actor.ActorPropery
{
    public class PaymentProperty
    {
        public string AccHolder { get; set; }
        public string BankName { get; set; }
        public string Branch { get; set; }
        public string BAccNo { get; set; }
        public string IfscCode { get; set; }
        public double Amount { get; set; }
        public string Email { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }


    }
}
