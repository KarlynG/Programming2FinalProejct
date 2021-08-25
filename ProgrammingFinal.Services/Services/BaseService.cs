using Microsoft.EntityFrameworkCore;
using ProgrammingFinal.Core.BaseModel;
using ProgrammingFinal.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingFinal.Services.Services
{
    public interface IBaseService<TEntity>
    {
        IQueryable<TEntity> AsQuery();
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(int id);
        Task<TEntity> AddAsync(TEntity entity);
        Task<TEntity> UpdateAsync(int id, TEntity entity);
        Task<TEntity> DeleteByIdAsync(int id);
    }
    public class BaseService<TEntity> : IBaseService<TEntity>
        where TEntity : class, IBase
    {
        public BaseService(IBaseRepository<TEntity> repository)
        {
            _repository = repository;
        }
        protected readonly IBaseRepository<TEntity> _repository;
        public virtual async Task<TEntity> AddAsync(TEntity entity)
        {
            var result = await _repository.Add(entity);
            return result;
        }

        public virtual IQueryable<TEntity> AsQuery()
        {
            return _repository.Query();
        }

        public async Task<TEntity> DeleteByIdAsync(int id)
        {
            var entity = await _repository.Get(id);
            if (entity is null)
                return null;

            var result = await _repository.Delete(id);
            return result;
        }

        public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            var result = await _repository.Query().ToListAsync();
            return result;
        }

        public virtual async Task<TEntity> GetByIdAsync(int id)
        {
            var result = await _repository.Get(id);
            return result;
        }

        public virtual async Task<TEntity> UpdateAsync(int id, TEntity entity)
        {
            var myEntity = await _repository.Get(id);
            if (myEntity is null)
                return null;

            var result = await _repository.Update(entity);
            return result;
        }
    }
}
