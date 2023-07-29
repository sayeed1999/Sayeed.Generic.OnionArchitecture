using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sayeed.Generic.OnionArchitecture.Logic
{
    public interface IBaseService<T> where T : class
    {
        public Task<int> SaveChangesAsync();

        public Task<IEnumerable<T>> GetAllAsync(int page = 1, int pageSize = 10);
        public Task<T> FindByIdAsync(long id); // FindAsync() is only for PK's!
        public Task<T> AddAsync(T item);
        public Task<T> UpdateAsync(T item);
        public Task<T> UpdateByIdAsync(long id, T item);
        public Task<T> Delete(T item);
        public Task<T> DeleteByIdAsync(long id);

    }
}
