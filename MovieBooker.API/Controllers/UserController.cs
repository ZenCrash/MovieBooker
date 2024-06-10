using Microsoft.AspNetCore.Mvc;
using MovieBooker.API.Dto;
using MovieBooker.API.Interface;
using MovieBooker.API.Repository;
using MovieBooker.API.Model;

namespace MovieBooker.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : IControllerAsync<UserDto.Display, UserDto.Edit, string>
    {
        private UserRepository _repository;

        public UserController(UserRepository repository) 
        {
            _repository = repository;
        }

        /* Get */

        //Get
        [HttpGet("{id}")]
        public async Task<UserDto.Display> Get(string id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return entity != null ? UserDto.Display.ToDto(entity) : null;
        }

        //Getall
        [HttpGet(Name = $"GetAll{nameof(User)}")]
        public async Task<IEnumerable<UserDto.Display>> GetAll()
        {
            var entityList = await _repository.GetAllAsync();
            return entityList.Select(UserDto.Display.ToDto);
        }

        //Get by email
        [HttpGet("{email}")]
        public async Task<UserDto.Display> GetByEmail(string email)
        {
            var entity = await _repository.GetByEmailAsync(email);
            return entity != null ? UserDto.Display.ToDto(entity) : null;
        }

        //Get by Username
        [HttpGet("{username}")]
        public async Task<UserDto.Display> GetByUsername(string username)
        {
            var entity = await _repository.GetByUsernameAsync(username);
            return entity != null ? UserDto.Display.ToDto(entity) : null;
        }

        //Get by username & Email
        [HttpGet("{email}/{username}")]
        public async Task<UserDto.Display> GetByEmailAndUsername(string email ,string username)
        {
            var entity = await _repository.GetByEmailAndUsername(email, username);
            return entity != null ? UserDto.Display.ToDto(entity) : null;
        }

        /* Create */

        //Create
        //TODO: change signature of dtomapper method, and what gets sendt down
        [HttpPost(Name = $"Create{nameof(User)}")]
        public async Task<bool> Create(UserDto.Edit dto)
        {
            var entity = await _repository.CreateAsync(dto.ToModel());
            return entity;
        }

        /* Update */

        //Update
        [HttpPut(Name = $"Update{nameof(User)}")]
        public async Task<bool> Update(UserDto.Edit dto)
        {
            var entity = await _repository.UpdateAsync(dto.ToModel());
            return entity;
        }

        /* Delete */

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
