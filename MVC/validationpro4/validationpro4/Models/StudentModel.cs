using System.ComponentModel.DataAnnotations;

namespace validationpro4.Models
{
    public class StudentModel
    {
        [Required(ErrorMessage = "Name is Required. It cannot be empty")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Mobile number is Required.")]
        public string Mobilenumber { get; set; }
    }
}
