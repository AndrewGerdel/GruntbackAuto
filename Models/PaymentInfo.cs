using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace GruntbackAuto.Models
{
    public class PaymentInfoContext : DbContext
    {
        public DbSet<PaymentInfo> PaymentInfos { get; set; }
    }
    public class PaymentInfo
    {
        /// <summary>
        /// In a real world app I would encrypt this value  Todo?
        /// </summary>
        public string CreditCardNumber { get; set; }

        public int CCV { get; set; }

        public string BillingZip { get; set; }
    }
}
