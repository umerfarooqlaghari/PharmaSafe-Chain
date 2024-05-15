using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;


public enum GenderOptions
{
    Male,
    Female
}

namespace ProjectLearn.Models.UserManagementModels
{
    public class UserTable
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Username is required")]
        public string? Username { get; set; }

        public string? Password { get; set; }

        public string? Password2 { get; set; }

        [EmailAddress(ErrorMessage = "Invalid email address")]
        [Required(ErrorMessage = "Email address is required")]
        public string? Email { get; set; }

        [Phone(ErrorMessage = "Invalid phone number")]
        public string? PhoneNumber { get; set; }

        [EnumDataType(typeof(GenderOptions), ErrorMessage = "Invalid gender")]
        public string? Gender { get; set; }

        public string? Residential_City { get; set; }   
        public int? Residential_Region { get; set; }
        public String? Residential_Address { get; set; }
    }
}
