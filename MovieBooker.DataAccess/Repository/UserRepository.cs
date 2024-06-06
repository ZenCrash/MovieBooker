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
            return await _context.Users.ToListAsync();
        }

        //Get
        public async Task<User> GetByIdAsync(string id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task<User> GetByEmailAsync(string email)
        {
            return await _context.Users.FindAsync(email);
        }

        //update
        public async Task<bool> UpdateAsync(User entity)
        {
            _context.Users.Update(entity);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
