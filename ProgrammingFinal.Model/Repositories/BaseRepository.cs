using Microsoft.EntityFrameworkCore;
using ProgrammingFinal.Core.BaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingFinal.Model.Repositories
{
    public interface IBaseRepository<TEntity>
    {
        IQueryable<TEntity> Query();
        Task<TEntity> Get(int id);
        Task<TEntity> Add(TEntity entity);
        Task<TEntity> Update(TEntity entity);
        Task<TEntity> Delete(int id);
    }
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class, IBase
    {
        protected readonly DbContext _context;
        protected readonly DbSet<TEntity>  _set;
        public BaseRepository(DbContext context)
        {
            _context = context;
            _set = context.Set<TEntity>();
        }

        public async Task<TEntity> Add(TEntity entity)
        {
            var result = await _set.AddAsync(entity);
            await _context.SaveChangesAsync();

            return result.Entity;
        }

        public async Task<TEntity> Delete(int id)
        {
            var entity = await Get(id);
            var result = _set.Remove(entity);
            await _context.SaveChangesAsync();

            return result.Entity;
        }

        public async Task<TEntity> Get(int id)
        {
            var entity = await _set.Where(x => x.Id == id).FirstOrDefaultAsync();
            return entity;
        }

        public IQueryable<TEntity> Query()
        {
            return _set.AsQueryable();
        }

        public async Task<TEntity> Update(TEntity entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
