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
    public class RoleRepository : IRepositoryAsync<RoleDto, string>
    {
        private readonly MovieBookerContext _context;

        public RoleRepository()
        {
            _context = new();
        }

        public async Task<bool> CreateAsync(RoleDto entity)
        {
            //Identity.Usermanager is responsable for this task
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteByIdAsync(string id)
        {
            //Identity.Usermanager is responsable for this task
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<RoleDto>> GetAllAsync()
        {
            var entityList = await _context.Roles.ToListAsync();
            var dtoList = entityList.Select(e => RoleDto.ToDto(e)).ToList();
            return dtoList;
        }

        public async Task<RoleDto> GetByIdAsync(string id)
        {
            var entity = await _context.Roles.FindAsync(id);
            var dto = entity != null ? RoleDto.ToDto(entity) : null;
            return dto;
        }

        public async Task<bool> UpdateAsync(RoleDto entity)
        {
            //Identity.Usermanager is responsable for this task
            throw new NotImplementedException();
        }
    }
}
