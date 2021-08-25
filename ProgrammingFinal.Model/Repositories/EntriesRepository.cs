using ProgrammingFinal.Model.Bussiness;
using ProgrammingFinal.Model.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingFinal.Model.Repositories
{
    public interface IEntriesRepository : IBaseRepository<Entries> { }
    public class EntriesRepository : BaseRepository<Entries>, IEntriesRepository
    {
        public EntriesRepository(ProgrammingFinalContext context) : base(context)
        {
        }
    }
}
