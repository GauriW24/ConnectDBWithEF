using System.ComponentModel.DataAnnotations;

namespace ConnectDBWithEF.Models
{
    public class Employee
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [EmailAddress(ErrorMessage = "Invalid Email")]
        public string Email { get; set; }

        //public string Course { get; set; }

        [Required(ErrorMessage = "Contact number is required")]
        [RegularExpression(@"^[0-9]{10}$", ErrorMessage = "Invalid contact number")]
        public string Contact { get; set; }

    }
}