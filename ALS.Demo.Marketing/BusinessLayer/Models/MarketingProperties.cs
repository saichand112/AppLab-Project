using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace ALS.Demo.Marketing.BusinessLayer.Models
{
    [MetadataType(typeof(MarketingProperties))]
    public partial class Marketing
    {
    }

    public partial class MarketingProperties
    {

        public int Id { get; set; }


        [Required]
        [Display(Name="Employe Name")]
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