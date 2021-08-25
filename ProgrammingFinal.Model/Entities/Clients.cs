using ProgrammingFinal.Core.BaseModel;
using ProgrammingFinal.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingFinal.Model.Entities
{
    public class Clients : Base
    {
        public int Document { get; set; }
        public string Name { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public ClientType Category { get; set; }
    }
}
