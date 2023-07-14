using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CommonLayer.Model
{
    public class EmployeeModel
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        [Required(ErrorMessage = "{0} field is required")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "{0} field is required")]
        public string ProfileImage { get; set; }
        [Required(ErrorMessage = "{0} field is required")]
        public DateTime StartDate { get; set; }
        [Required(ErrorMessage = "{0} field is required")]
        public string Department { get; set; }
        [Required(ErrorMessage = "{0} field is required")]
        public decimal Salary { get; set; }
        [Required(ErrorMessage = "{0} field is required")]
        
        public DateTime CreatedAt { get; set; }
        [Required(ErrorMessage = "{0} field is required")]
        public DateTime UpdatedAt { get; set; }
        [Required(ErrorMessage = "{0} field is required")]
        public string Notes { get; set; }


    }
}
