using Microsoft.AspNetCore.Mvc;
using MovieBooker.API.Dto;
using MovieBooker.API.DtoConvert;
using MovieBooker.API.Interface;
using MovieBooker.DataAccess.Model;
using MovieBooker.DataAccess.Repository;

namespace MovieBooker.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoleController : ControllerBase, IController<RoleDto, string>
    {
        private RoleRepository _repository { get; init; } = new();

        [HttpPost(Name = $"Create{nameof(Role)}")]
        public async Task<bool> Create(RoleDto dto)
        {
            var entity = await _repository.CreateAsync(dto.ToModel());
            return entity;
        }

        [HttpDelete(Name = $"Delete{nameof(Role)}")]
        public async Task<bool> Delete(string id)
        {
            var entity = await _repository.DeleteByIdAsync(id);
            return entity;
        }

        [HttpGet("{id}")]
        public async Task<RoleDto> Get(string id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return (entity != null) ? entity.ToDto() : null;
        }

        [HttpGet(Name = $"GetAll{nameof(Role)}")]
        public async Task<IEnumerable<RoleDto>> GetAll()
        {
            var entityList = await _repository.GetAllAsync();
            return entityList.Select(entity => entity.ToDto());
        }

        [HttpPut(Name = $"Update{nameof(Role)}")]
        public async Task<bool> Update(RoleDto dto)
        {
            var entity = await _repository.UpdateAsync(dto.ToModel());
            return entity;
        }
    }
}
