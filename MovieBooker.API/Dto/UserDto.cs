namespace MovieBooker.API.Dto
{
    public class UserDto
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string FullName { get { return $"{FirstName} {LastName}"; } }

        //Full model
        public UserDto(string id, string username, string password, string firstName,
                       string lastName, string email,string phoneNumber)
        {
            Id = id;
            UserName = username;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        public UserDto(string username, string password, string firstName,
                       string lastName, string email, string phoneNumber, int placeholder = 0)
        {
            UserName = username;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        //without password
        public UserDto(string id, string username, string firstName,
                       string lastName, string email, string phoneNumber)
        {
            Id = id;
            UserName = username;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
        }
    }
    

}
