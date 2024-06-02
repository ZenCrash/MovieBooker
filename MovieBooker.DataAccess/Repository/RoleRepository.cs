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
    public class RoleRepository : IRepositoryAsync<Role, string>
    {
        private readonly MovieBookerContext _context;

        //create
        public async Task<bool> CreateAsync(Role entity)
        {
            _context.Roles.AddAsync(entity);
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

        //GetAll
        public async Task<IEnumerable<Role>> GetAllAsync()
        {
            return await _context.Roles.ToListAsync();
        }

        //Get
        public async Task<Role> GetByIdAsync(string id)
        {
            return await _context.Roles.FindAsync(id);
        }

        //Update
        public async Task<bool> UpdateAsync(Role entity)
        {
            _context.Roles.Update(entity);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
