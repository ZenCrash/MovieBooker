using Microsoft.AspNetCore.Identity;
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
                Password = null,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                PhoneNumber = model.PhoneNumber,
            };
        }

        public static User ToModel(this UserDto dto)
        {
            IPasswordHasher<UserDto> userManager = new PasswordHasher<UserDto>();

            return new User
            {
                Id = dto.Id,
                UserName = dto.UserName,
                PasswordHash = userManager.HashPassword(dto, dto.Password),
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Email = dto.Email,
                PhoneNumber = dto.PhoneNumber,
            };
        }
    }
}
