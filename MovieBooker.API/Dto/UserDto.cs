using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MovieBooker.API.Model;
using System.Runtime.CompilerServices;

namespace MovieBooker.API.Dto
{
    public class UserDto
    {
        //Display
        public class Display
        {
            public string Id { get; set; }
            public string FullName { get { return $"{FirstName} {LastName}"; } }
            public string UserName { get; init; }
            public string NormalizedUserName { get; init; }
            public string FirstName { get; init; }
            public string LastName { get; init; }
            public string Email { get; init; }
            public string NormilaziedEmail { get; init; }
            public string PhoneNumber { get; init; }

            public static Display ToDto(User user)
            {
                return new UserDto.Display
                {
                    Id = user.Id,
                    UserName = user.UserName,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    PhoneNumber = user.PhoneNumber,
                };
            }
        }

        //Database creation entry
        public class Edit
        {
            public string Id { get; set; } = null;
            public string UserName { get; init; }
            public string NormalizedUserName { get; init; }
            public string PasswordHashed { get; init; }
            public string FirstName { get; init; }
            public string LastName { get; init; }
            public string Email { get; init; }
            public string NormilaziedEmail { get; init; }
            public string PhoneNumber { get; init; }

            public User ToModel()
            {
                return new User
                {
                    UserName = this.UserName,
                    NormalizedUserName = this.UserName.ToUpper(),
                    PasswordHash = this.PasswordHashed,
                    FirstName = this.FirstName,
                    LastName = this.LastName,
                    Email = this.Email,
                    NormalizedEmail = this.Email.ToUpper(),
                    PhoneNumber = this.PhoneNumber,
                };
            }
        }

    }
    

}
