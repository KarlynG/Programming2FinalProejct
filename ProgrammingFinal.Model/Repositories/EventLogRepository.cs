using ProgrammingFinal.Model.Bussiness;
using ProgrammingFinal.Model.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingFinal.Model.Repositories
{
    public interface IEventLogRepository : IBaseRepository<EventLog> { }
    public class EventLogRepository : BaseRepository<EventLog>, IEventLogRepository
    {
        public EventLogRepository(ProgrammingFinalContext context) : base(context)
        {

        }
    }
}
