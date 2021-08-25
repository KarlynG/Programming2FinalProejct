using ProgrammingFinal.Core.BaseModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingFinal.Model.Bussiness
{
    public class Entries : Base
    {
        public DateTime DateAdded { get; set; }
        public string ProductName { get; set; }
        public int VendorId { get; set; }
        public int Quantity { get; set; }
    }
}
