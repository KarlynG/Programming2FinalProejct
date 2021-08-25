using ProgrammingFinal.Model.Bussiness;
using ProgrammingFinal.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingFinal.Services.Services
{
    public interface IEventLogService : IBaseService<EventLog>
    {
        Task<List<EventLog>> GetEventLogAsyncData();
    }
    public class EventLogService : BaseService<EventLog>, IEventLogService
    {
        public EventLogService(IEventLogRepository repository) : base(repository)
        {

        }

        public async Task<List<EventLog>> GetEventLogAsyncData()
        {
            IEnumerable<EventLog> eventLogs = await GetAllAsync();
            List<EventLog> result = (from s in eventLogs select s).ToList();
            result.Reverse();
            return result;
        }
    }
}
