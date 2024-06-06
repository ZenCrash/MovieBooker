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
            return new UserDto(model.Id, 
                               model.UserName, 
                               model.FirstName, 
                               model.LastName, 
                               model.Email, 
                               model.PhoneNumber);
        }

        //create/update - model
        public static User ToModel(this UserDto dto)
        {

            return new User
            {
                UserName = dto.UserName,
                NormalizedUserName = dto.UserName.ToUpper(),
                PasswordHash = dto.Password,
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Email = dto.Email,
                NormalizedEmail = dto.Email.ToUpper(),
                PhoneNumber = dto.PhoneNumber,
            };
        }
    }
}
