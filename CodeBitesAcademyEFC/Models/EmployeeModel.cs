using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CodeBitesAcademyEFC.Models
{
    public class EmployeeModel
    {
        [Key]
        public int Id { get; set; }


        [Display( Name = "First Name")]
        [Required]
        [DataType(DataType.Text)]
        [StringLength(20, MinimumLength = 3)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        [DataType(DataType.Text)]
        [StringLength(20, MinimumLength = 3)]
        public string LasttName { get; set; }

        [Required]
        [Range(18, 100)]
        public int Age { get; set; }

        [Display(Name = "Email Address")]
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Home Address")]
        [Required]
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }

        [Display(Name = "Phone Number")]
        [Required]
        [DataType(DataType.PhoneNumber)]
        public int Number { get; set; }
    }
}
