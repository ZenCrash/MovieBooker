using Microsoft.EntityFrameworkCore;
using MovieBooker.DataAccess.Dto;
using MovieBooker.DataAccess.Interface;
using MovieBooker.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBooker.DataAccess.Repository
{
    public class UserRepository : IRepositoryAsync<UserDto, string>
    {
        private readonly MovieBookerContext _context;
        public UserRepository()
        {
            _context = new();
        }

        /* Create */
        //Create
        public async Task<bool> CreateAsync(UserDto entity)
        {
            //Identity.Usermanager is responsable for this task
            throw new NotImplementedException();
            //_context.Users.AddAsync(entity);
            //return await _context.SaveChangesAsync() > 0;
        }

        /* Get */

        //Getall
        public async Task<IEnumerable<UserDto>> GetAllAsync()
        {
            var entityList = await _context.Users.ToListAsync();
            var dtoList = entityList.Select(e => UserDto.ToDto(e)).ToList();
            return dtoList;
        }

        //Get
        public async Task<UserDto> GetByIdAsync(string id)
        {
            var entity = await _context.Users.FindAsync(id);
            var dto = entity != null ? UserDto.ToDto(entity) : null;
            return dto;
        }

        //Get by Email
        public async Task<UserDto> GetByEmailAsync(string email)
        {
            var entity = await _context.Users.SingleOrDefaultAsync(e => e.NormalizedEmail == email.ToUpper());
            var dto = entity != null ? UserDto.ToDto(entity) : null;
            return dto;
        }

        //Get by Username
        public async Task<UserDto> GetByUsernameAsync(string username)
        {
            var entity = await _context.Users.SingleOrDefaultAsync(e => e.NormalizedUserName == username.ToUpper());
            var dto = entity != null ? UserDto.ToDto(entity) : null;
            return dto;

        }

        //Get by Phonenumber
        public async Task<UserDto> GetByPhoneNumberAsync(string phoneNumber)
        {
            var entity = await _context.Users.SingleOrDefaultAsync(e => e.PhoneNumber == phoneNumber);
            var dto = entity != null ? UserDto.ToDto(entity) : null;
            return dto;
        }

        /* Delete */

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

        /* Update */

        //update
        public async Task<bool> UpdateAsync(UserDto entity)
        {
            //Identity.Usermanager is responsable for this task
            throw new NotImplementedException();
            //_context.Users.Update(entity);
            //return await _context.SaveChangesAsync() > 0;
        }
    }
}
