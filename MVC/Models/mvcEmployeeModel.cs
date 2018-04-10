using System;
using System.Collections.Generic;
using System.Globalization;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class mvcEmployeeModel
    {
        public int EmployeeID { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [StringLength(20, MinimumLength = 4)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [StringLength(20, MinimumLength = 4)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public Nullable<int> Gender { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [Display(Name = "Function")]
        public Nullable<int> Functions { get; set; }

        [Range(20, 40, ErrorMessage = "The age category should be between 20 year and 40 year")]
        [Required(ErrorMessage = "This field is required")]
        public Nullable<int> Age { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [Range(1300, 1600, ErrorMessage = "Price must be between 1300 euro and 1600 euro")]
        public Nullable<int> Salary { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [Display(Name = "Hire Date")]
        public Nullable<System.DateTime> HireDate { get; set; }
    }
}