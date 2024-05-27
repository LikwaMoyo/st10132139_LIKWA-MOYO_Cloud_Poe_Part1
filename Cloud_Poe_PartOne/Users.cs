using System;

namespace Cloud_Poe_PartOne
{
    public class Users
    {
        public int UserID { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string PhoneNumber { get; set; }

        // Constructor for initializing a new user
        public Users(int userID, string email, string name, string password, string role, string phoneNumber)
        {
            UserID = userID;
            Email = email;
            Name = name;
            Password = password;
            Role = role;
            PhoneNumber = phoneNumber;
        }

        // Parameterless constructor for cases where you might need it
        public Users() { }

        // Method to display user information (optional)
        public override string ToString()
        {
            return $"UserID: {UserID}, Email: {Email}, Name: {Name}, Role: {Role}, PhoneNumber: {PhoneNumber}";
        }
    }
}
