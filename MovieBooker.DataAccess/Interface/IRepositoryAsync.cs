using MovieBooker.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBooker.DataAccess.Interface
{
    public interface IRepositoryAsync<T, IdType> where T : class
    {
        public Task<IEnumerable<T>> GetAllAsync();
        public Task<T> GetByIdAsync(IdType id);
        public Task<bool> CreateAsync(T entity);
        public Task<bool> UpdateAsync(T entity);
        public Task<bool> DeleteByIdAsync(IdType id);
    }
}
