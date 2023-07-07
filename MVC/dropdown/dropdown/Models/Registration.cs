using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace dropdown.Models
{
    public class Registration
    {
        [Required(ErrorMessage = "Enter State")]
        public string State { get; set; }
        [Required(ErrorMessage = "Enter City")]
        public string City { get; set; }
    }
}