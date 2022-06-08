using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ValidationInMVC.Models
{
    public class EmployeeViewModel
    {
        [Required(ErrorMessage ="Please Enter First Name")]
        [Display(Name ="First Name")]
        [MaxLength(12,ErrorMessage ="Please Provide valid string")]
        [MinLength(2,ErrorMessage ="Please Enter name atlest 2 char")]
        public string firstName { get; set; }

        [Required(ErrorMessage ="Please Enter Last Name")]
        [Display(Name = "Last Name")]
        [MaxLength(12, ErrorMessage = "Please Provide valid string")]
        [MinLength(2, ErrorMessage = "Please Enter name atlest 2 char")]
        public string lastName { get; set; }

        [Required(ErrorMessage ="Please Enter the salary")]
        [Range(5000,200000, ErrorMessage ="Please Enter Value in Valid Range")]
        public int Salary { get; set; }


        [Required(ErrorMessage ="Please Enter Email Address")]
       
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",ErrorMessage ="Please Enter Valid EmailId")]
        [CustomEmailValidation(ErrorMessage ="Email id is already exist")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage ="Please Enter Phone Number")]
        [MaxLength(10, ErrorMessage ="Invalid Phone Number")]
        [MinLength(10,ErrorMessage ="Please Enter Valid Phone Number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage ="Please Enter Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please Enter ConfirmedPassword")]
        [Compare("Password",ErrorMessage ="Password and confirmed password has not been matched")]
        public string ConfirmPassword { get; set; }




    }

}