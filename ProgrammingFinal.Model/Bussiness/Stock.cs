using ProgrammingFinal.Core.BaseModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingFinal.Model.Bussiness
{
    public class Stock : Base
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }

    }
}
