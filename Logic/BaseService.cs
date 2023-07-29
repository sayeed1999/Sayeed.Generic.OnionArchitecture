using Microsoft.EntityFrameworkCore;
using Sayeed.Generic.OnionArchitecture.Repository;

namespace Sayeed.Generic.OnionArchitecture.Logic
{
    public class BaseService<T> : IBaseService<T> 
        where T : class
    {
        protected IBaseRepository<T> _repository;
        public BaseService(IBaseRepository<T> baseRepository)
        {
            _repository = baseRepository;

        }

        /// <summary>
        /// Need to be called after certain operations on db: add update delete, otherwise changes will not be saved..
        /// </summary>
        /// <returns></returns>
        public virtual async Task<int> SaveChangesAsync()
        {
            return await _repository.SaveChangesAsync();
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync(int page = 1, int pageSize = 10)
        {
            return await _repository.GetAllAsync(page: page, pageSize: pageSize);
        }

        public virtual async Task<T> FindByIdAsync(long id)
        {
            return await _repository.FindByIdAsync(id);
        }

        public virtual async Task<T> AddAsync(T item)
        {
            return await _repository.AddAsync(item);
        }

        public virtual async Task<T> UpdateByIdAsync(long id, T item)
        {
            return await _repository.UpdateByIdAsync(id, item);
        }

        public virtual async Task<T> UpdateAsync(T item)
        {
            return await _repository.UpdateAsync(item);
        }

        public virtual async Task<T> Delete(T item)
        {
            return await _repository.DeleteAsync(item);
        }

        public virtual async Task<T> DeleteByIdAsync(long id)
        {
            return await _repository.DeleteByIdAsync(id);
        }

    }
}
