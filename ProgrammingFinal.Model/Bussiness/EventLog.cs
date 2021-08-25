using ProgrammingFinal.Core.BaseModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingFinal.Model.Bussiness
{
    public class EventLog : Base
    {
        public DateTime Date { get; set; }
        public string Entry { get; set; }
    }
}
