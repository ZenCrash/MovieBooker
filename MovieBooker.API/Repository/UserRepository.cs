using Microsoft.EntityFrameworkCore;
using MovieBooker.API.Interface;
using MovieBooker.API.Model;

namespace MovieBooker.API.Repository
{
    public class UserRepository : IRepositoryAsync<User, string>
    {
        private readonly MovieBookerContext _context;
        public UserRepository(MovieBookerContext context)
        {
            _context = context;
        }

        /* Create */
        public async Task<bool> CreateAsync(User entity)
        {
            _context.Users.AddAsync(entity);
            return await _context.SaveChangesAsync() > 0;
        }

        /* Delete */
        public async Task<bool> DeleteByIdAsync(string id)
        {
            var entity = await GetByIdAsync(id);
            if (entity != null)
            {
                _context.Remove(entity);
                return await _context.SaveChangesAsync() > 0;
            }
            return false;
        }

        /* Get */
        //Get All
        public async Task<IEnumerable<User>> GetAllAsync() //
        {
            throw new NotImplementedException();
        }

        //Get by Id
        public async Task<User> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        //Get by Email
        public async Task<User> GetByEmailAsync(string email)
        {
            return await _context.Users.SingleOrDefaultAsync(e => e.NormalizedEmail == email.ToUpper());
        }

        //Get by Username
        public async Task<User> GetByUsernameAsync(string username)
        {
            //username sould by default be email. so we check that first
            //if not get by username
            var entity = await _context.Users.SingleOrDefaultAsync(e => e.NormalizedEmail == username.ToUpper());
            if (entity == null)
            {
                entity = await _context.Users.SingleOrDefaultAsync(e => e.NormalizedUserName == username.ToUpper());
            }
            return entity;

        }

        //Get by Username & Email //Depricated
        public async Task<User> GetByEmailAndUsername(string email, string username)
        {
            return await _context.Users.SingleOrDefaultAsync(e => e.NormalizedEmail == email.ToUpper() &&
                                                                    e.NormalizedUserName == username.ToUpper());
        }

        /* Update */
        public async Task<bool> UpdateAsync(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
