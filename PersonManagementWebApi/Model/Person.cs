using System.ComponentModel.DataAnnotations;

namespace PersonManagementWebApi.Model
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required]
        [RegularExpression("^[0-9]{10}$", ErrorMessage = "Phone Number must be 10 digits")]
        public string PhoneNumber { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
    }
}
