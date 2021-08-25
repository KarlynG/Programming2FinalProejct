using ProgrammingFinal.Core.BaseModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingFinal.Model.Entities
{
    public class Products : Base
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
