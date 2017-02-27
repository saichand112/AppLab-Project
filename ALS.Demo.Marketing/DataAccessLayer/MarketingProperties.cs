using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace ALS.Demo.Marketing.DataAccessLayer
{
    [MetadataType(typeof(MarketingProperties))]
    public partial class Marketing
    {
    }
   
    public partial class MarketingProperties
    {

        public int Id { get; set; }

        //[Required(ErrorMessage="Please Select a Employee")]
        //public Nullable<int> EmpId { get; set; }


        //[Required(ErrorMessage = "Please Select a Marketer")]
        //public Nullable<int> MarketerId { get; set; }
    


        [Display(Name="Employe Name")]
        [Required]
        public string EmpName { get; set; }


        [Required]
        public string MarketerName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public System.DateTime StartDate { get; set; }

       [Required]
        public string Status { get; set; }


        public Nullable<System.DateTime> DateClosed { get; set; }



    }
}