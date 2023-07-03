using System.ComponentModel.DataAnnotations;

namespace validationpro3.Models
{
    public class StudentModel
    {
        [Required(ErrorMessage = "Name is Required. It cannot be empty")]
        public string UserName { get; set; }
    }
}
