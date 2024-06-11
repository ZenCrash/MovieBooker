using MovieBooker.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBooker.DataAccess.Dto
{
    public class UserDto()
    {
        //Display - //Get //Getall
        public string Id { get; set; }
        public string FullName { get { return $"{FirstName} {LastName}"; } }
        public string UserName { get; init; }
        public string NormalizedUserName { get; init; }
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public string Email { get; init; }
        public string NormilaziedEmail { get; init; }
        public string PhoneNumber { get; init; }

        //Get requests (from model to dto)
        public static UserDto ToDto(User model)
        {
            return new UserDto
            {
                Id = model.Id,
                UserName = model.UserName,
                NormalizedUserName = model.UserName.ToUpper(),
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                NormilaziedEmail = model.Email.ToUpper(),
                PhoneNumber = model.PhoneNumber,
            };
        }
    }
}
