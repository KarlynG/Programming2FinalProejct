using ProgrammingFinal.Core.BaseModel;
using ProgrammingFinal.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingFinal.Model.Bussiness
{
    public class Billing : Base
    {
        public DateTime BillingDate { get; set; }
        public string ProductName { get; set; }
        public int QuantityBought { get; set; }
        public string ClientName { get; set; }
        public int PremiumDiscount { get; set; } = 0;
        public int Itbis { get; set; }
        public int Total { get; set; }
    }
}
