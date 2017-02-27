using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ALS.Demo.Marketing.BusinessLayer.Models
{
    [MetadataType(typeof(EmployeProperties))]
   public partial class Employee
   {

   }

    public partial class EmployeProperties
    {
        public int Id { get; set; }
        [Required]
        [Key]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public bool IsInternalEmployee { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }

        //[Required]
        [StringLength(10)]
        [DataType(DataType.PhoneNumber)]
        public int PhoneNumber { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public System.DateTime DateOfBirth { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public string DrivingLicense { get; set; }


        public Nullable<System.DateTime> DateCreated { get; set; }



    }
    
}