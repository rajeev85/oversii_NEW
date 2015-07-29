using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Oversii.Models.DB;

namespace Oversii.Models.ViewModel
{
    public class UserAccount
    {
        [Key]
        public  int UserID { get; set; }
        public  int RoleID { get; set; }
        [Required(ErrorMessage = "Please enter your First Name")]
        [Display(Name = "First Name")]
        public  string FirstName { get; set; }
        [Required(ErrorMessage = "please enter your Last Name")]
        [Display(Name = "Last Name")]
        public  string LastName { get; set; }
        [Required(ErrorMessage = "Please enter your Email ID")]
        [Display(Name = "Email")]
        public  string Email { get; set; }
        [Required(ErrorMessage = "Please enter the password")]
        [Display(Name = "Password")]
        public  string Password { get; set; }
        [Required(ErrorMessage = "Please enter Phone Number")]
        [Display(Name = "Phone1")]
        public  string Phone1 { get; set; }
        public  string Phone2 { get; set; }
    }

    public class UserLoginView
    {
        [Key]
        public int UserID { get; set; }
        [Required(ErrorMessage = "Please Enter a Valid EmailID")]
        [Display(Name = "Email ID")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please Enter a password")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
             
        public string ErrMsg { get; set; }
        public string Role { get; set; }
        public string IsLoginSuccess { get; set; }

        //public int ResidentID { get; set; }
        //public Nullable<int> PropID { get; set; }
        //public Nullable<int> subDivisionID { get; set; }
        //public Nullable<int> streetID { get; set; }
        //public Nullable<int> houseID { get; set; }
        //public String AssignedParkingUnit { get; set; }
        //public String MailingAddr { get; set; }
        //public String MailingCity { get; set; }
        //public String MailingState { get; set; }
        //public String MailingZipCode { get; set; }
        //public virtual house_address house_address { get; set; }
        //public virtual property property { get; set; }
        //public virtual street street { get; set; }
        //public virtual subdivision subdivision { get; set; }

    }

    //public class resident
    //{
    //    public int ResidentID { get; set; }
    //    public String MailingAddr { get; set; }
    //    public String MailingCity { get; set; }
    //    public String MailingState { get; set; }
    //    public String MailingZipCode { get; set; }
    //    public String AssignedParkingUnit { get; set; }
    //}

    public class propertyList
    {
        [Key]
        public int propID { get; set; }

        [Required(ErrorMessage = "Please enter Zip Code")]
        public String zipcode { get; set; }
        public List<string> propertyname { get; set; }
    }
}