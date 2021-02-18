using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoginRegistration.Models
{   
    public class LoginUser // View Model rather than just Model - will not be saved in the database
    {
        // [NotMapped]
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        // [NotMapped]
        [DataType(DataType.Password)]
        [Required]
        [MinLength(8)]
        public string Password { get; set; }
    }

}