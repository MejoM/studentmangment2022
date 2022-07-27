using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace studentmangment2022.Models
{
    public partial class Student
    {
        public int Regno { get; set; }
        [Required(ErrorMessage = "Name Required")]
        [MinLength(3, ErrorMessage = "min length more than 3 char")]
        [RegularExpression(@"^[A-Z]+[a-zA-z\s]*$", ErrorMessage = "First letter must be capital and Number cannot be accepted")]
        [Display(Name="NAME")]
        public string StudentFullName { get; set; }
 
        [Display(Name = "COURSE")]
        public string CourseJoin { get; set; }
        [Required(ErrorMessage = "Fees Required")]
        [Range(10000,15000,ErrorMessage = "Fees between 10000 to 15000")]
        [Display(Name = "FEES")]
        public decimal CourseFee { get; set; }
        [Required(ErrorMessage = "BatchId Required")]
        [Display(Name = "BATCH ID")]
        public string BatchId { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy}")]
        [Display(Name = "DOJ")]
        public DateTime Doj { get; set; }
        [Required(ErrorMessage = "Fees Required")]
        [Display(Name = "ADDRESS")]
        public string StudentAddress { get; set; }
        [Required(ErrorMessage = "Phone Number Required!")]

        [RegularExpression(@"^[6-9]\d{9}$", ErrorMessage = "Plese enter Valid Number and Does not Exceeds 10 numbers ")]
        [Display(Name = "CONTACT")]
        public string MobileNumber { get; set; }
        [Required(ErrorMessage = "E mail Id Required")]
        [Display(Name = "E-MAIL")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression("^[a-z0-9_\\+-]+(\\.[a-z0-9_\\+-]+)*@[a-z0-9-]+(\\.[a-z0-9]+)*\\.([a-z]{2,4})$", ErrorMessage = "Invalid email format.")]

        public string EmailId { get; set; }
    }
}
