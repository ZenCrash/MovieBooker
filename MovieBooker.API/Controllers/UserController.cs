using Microsoft.AspNetCore.Mvc;
using MovieBooker.API.Dto;
using MovieBooker.API.Interface;
using MovieBooker.DataAccess.Model;
using MovieBooker.DataAccess.Repository;

namespace MovieBooker.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : IController<UserDto.Display, UserDto.Edit, string>
    {
        //private readonly UserRepository _repository;
        private UserRepository _repository { get; init; } = new();

        public UserController() 
        {
            
        }

        //Getall
        [HttpGet(Name = $"GetAll{nameof(User)}")]
        public async Task<IEnumerable<UserDto.Display>> GetAll()
        {
            var entityList = await _repository.GetAllAsync();
            return entityList.Select(UserDto.Display.ToDto);
        }

        //Get
        [HttpGet("{id}")]
        public async Task<UserDto.Display> Get(string id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return entity != null ? UserDto.Display.ToDto(entity) : null;
        }

        //Get by email
        [HttpGet("email/{email}")]
        public async Task<UserDto.Display> GetByEmail(string email)
        {
            var entity = await _repository.GetByEmailAsync(email);
            return entity != null ? UserDto.Display.ToDto(entity) : null;
        }

        //Create
        //TODO: change signature of dtomapper method, and what gets sendt down
        [HttpPost(Name = $"Create{nameof(User)}")]
        public async Task<bool> Create(UserDto.Edit dto)
        {
            var entity = await _repository.CreateAsync(dto.ToModel());
            return entity;
        }

        //Update
        [HttpPut(Name = $"Update{nameof(User)}")]
        public async Task<bool> Update(UserDto.Edit dto)
        {
            var entity = await _repository.UpdateAsync(dto.ToModel());
            return entity;
        }

        //Delete
        [HttpDelete(Name = $"Delete{nameof(User)}")]
        public async Task<bool> Delete(string id)
        {
            var entity = await _repository.DeleteByIdAsync(id);
            return entity;
        }

        //[HttpGet(Name = $"GetAll{nameof(User)}")]
        //[HttpGet("{id}")]
        //[HttpPost(Name = $"Create{nameof(User)}")]
        //[HttpPut(Name = $"Update{nameof(User)}")]
        //[HttpDelete(Name = $"Delete{nameof(User)}")]


    }
}
