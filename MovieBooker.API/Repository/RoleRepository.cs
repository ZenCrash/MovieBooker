using MovieBooker.API.Interface;
using MovieBooker.API.Model;

namespace MovieBooker.API.Repository
{
    public class RoleRepository : IRepositoryAsync<Role, string>
    {
        public Task<bool> CreateAsync(Role entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Role>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Role> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(Role entity)
        {
            throw new NotImplementedException();
        }
    }
}
