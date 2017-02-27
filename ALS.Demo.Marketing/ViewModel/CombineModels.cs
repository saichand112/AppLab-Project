using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ALS.Demo.Marketing.BusinessLayer.Models;
using ALS.Demo.Marketing.DataAccessLayer;

namespace ALS.Demo.Marketing.ViewModel
{
    public class CombineModels
    {
        public ALS.Demo.Marketing.DataAccessLayer.Employee employee { get; set; }

        public ALS.Demo.Marketing.DataAccessLayer.Marketing marketing { get; set; }
        
        
    }
}