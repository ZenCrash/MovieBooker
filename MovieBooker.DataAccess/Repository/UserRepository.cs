using Microsoft.EntityFrameworkCore;
using MovieBooker.DataAccess.Interface;
using MovieBooker.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBooker.DataAccess.Repository
{
    public class UserRepository : IRepositoryAsync<User, string>
    {
        private readonly MovieBookerContext _context;
        public UserRepository()
        {
            _context = new();
        }

        //Create
        public async Task<bool> CreateAsync(User entity)
        {
            _context.Users.AddAsync(entity);
            return await _context.SaveChangesAsync() > 0;
        }

        //Delete
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

        //Getall
        public async Task<IEnumerable<User>> GetAllAsync()
        {
            var entityList = await _context.Users.ToListAsync();
            entityList.ForEach(entity => entity.PasswordHash = string.Empty);
            return entityList;
        }

        //Get
        public async Task<User> GetByIdAsync(string id)
        {
            var entity = await _context.Users.FindAsync(id);
            entity.PasswordHash = string.Empty;
            return entity;
        }

        public async Task<User> GetByEmailAsync(string email)
        {
            return await _context.Users.SingleOrDefaultAsync(e => e.NormalizedEmail == email.ToUpper());
        }

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

        public async Task<User> GetByEmailAndUsername(string email, string username)
        {
            return await _context.Users.SingleOrDefaultAsync(e => e.NormalizedEmail == email.ToUpper() && 
                                                                    e.NormalizedUserName == username.ToUpper());
        }

        //update
        public async Task<bool> UpdateAsync(User entity)
        {
            _context.Users.Update(entity);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
