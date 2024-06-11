using MovieBooker.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBooker.DataAccess.Interface
{
    public interface IRepositoryAsync<Dto, IdType> where Dto : class
    {
        public Task<IEnumerable<Dto>> GetAllAsync();
        public Task<Dto> GetByIdAsync(IdType id);
        public Task<bool> CreateAsync(Dto entity);
        public Task<bool> UpdateAsync(Dto entity);
        public Task<bool> DeleteByIdAsync(IdType id);
    }
}
