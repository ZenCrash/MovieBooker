using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MovieBooker.DataAccess.Model;
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
            public string NormalizedUserName { get { return $"{UserName.ToUpper()}"; } }
            public string FirstName { get; init; }
            public string LastName { get; init; }
            public string Email { get; init; }
            public string NormilaziedEmail { get { return $"{Email.ToUpper()}"; } }
            public string PhoneNumber { get; init; }

            //TODO replace with a to dto class
            public User ToModel()
            {
                return new User
                {
                    Id = Id,
                    UserName = this.UserName,
                    NormalizedUserName = this.UserName,
                    FirstName = this.FirstName,
                    LastName = this.LastName,
                    Email = this.Email,
                    NormalizedEmail = this.Email,
                    PhoneNumber = this.PhoneNumber,
                };
            }
        }

        //Database creation entry
        public class Create
        {
            public string Id { get; set; } = null;
            public string UserName { get; init; }
            public string NormalizedUserName { get { return $"{UserName.ToUpper()}"; } }
            public string PasswordHashed { get; init; }
            public string FirstName { get; init; }
            public string LastName { get; init; }
            public string Email { get; init; }
            public string NormilaziedEmail { get { return $"{Email.ToUpper()}"; } }
            public string PhoneNumber { get; init; }

            public User ToModel()
            {
                return new User
                {
                    UserName = this.UserName,
                    NormalizedUserName = this.UserName,
                    PasswordHash = this.PasswordHashed,
                    FirstName = this.FirstName,
                    LastName = this.LastName,
                    Email = this.Email,
                    NormalizedEmail = this.Email,
                    PhoneNumber = this.PhoneNumber,
                };
            }
        }

    }
    

}
