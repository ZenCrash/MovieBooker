using MovieBooker.API.Dto;
using MovieBooker.API.Interface;
using MovieBooker.DataAccess.Model;
using System.Runtime.CompilerServices;

namespace MovieBooker.API.DtoConvert
{
    public static class UserMapper
    {
        public static UserDto ToDto(this User model)
        {
            return new UserDto
            {
                Id = model.Id,
                UserName = model.UserName,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                NormalizedEmail = model.NormalizedEmail,
                PhoneNumber = model.PhoneNumber,
            };
        }

        public static User ToModel(this UserDto dto)
        {
            return new User
            {
                Id = dto.Id,
                UserName = dto.UserName,
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Email = dto.Email,
                NormalizedEmail = dto.NormalizedEmail,
                PhoneNumber = dto.PhoneNumber,
            };
        }
    }
}
