using ProgrammingFinal.Core.BaseModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingFinal.Model.Entities
{
    public class Vendors : Base
    {
        public string Document { get; set; }
        public string Name { get; set; }
        public int PhoneNumber { get; set; }
        public string email { get; set; }
    }
}
