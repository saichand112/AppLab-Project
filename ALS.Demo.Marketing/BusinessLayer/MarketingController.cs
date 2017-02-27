using ALS.Demo.Marketing.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using ALS.Demo.Marketing.ViewModel;
namespace ALS.Demo.Marketing.BusinessLayer
{
    public class MarketingController : Controller
    {
        private AppLabDbs _context1;

        public MarketingController()
        {
            _context1 = new AppLabDbs();

        }
        protected override void Dispose(bool disposing)
        {
            _context1.Dispose();
        }
        // GET: Marketing
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetMarketingEmp()
        {
            var marketingemp = _context1.Marketings.ToList();


            return View(marketingemp);
        }





        public ActionResult MarketingProfile(Employee emp)
        {
           
           
           // var employee = _context1.Employees.ToList();

            IEnumerable<SelectListItem> items =(from m in _context1.Employees where m.IsInternalEmployee == false select m).AsEnumerable().Select(m => new SelectListItem  //_context1.Employees.Select(c =>new SelectListItem

            {

                Value = m.FirstName,
                Text = m.FirstName

            });
           // ViewData["items"] = items;

            ViewBag.Sai = items;
            IEnumerable<SelectListItem> items1 = (from m in _context1.Employees where m.IsInternalEmployee == true select m).AsEnumerable().Select(m => new SelectListItem   //_context1.Employees.Select(c =>new SelectListItem

            {

                Value = m.FirstName,
                Text = m.FirstName

            });

            //ViewData["items1"] = items1;


            ViewBag.Name= items1;

            return View();


        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(ALS.Demo.Marketing.DataAccessLayer.Marketing marketer)
        {

            
            if (!ModelState.IsValid)
            {
                return View("MarketingProfile");
            }
            if (marketer.Id == 0)
             
                
                _context1.Marketings.Add(marketer);
            
            //else
            //{
            //    var update = _context.Employees.SingleOrDefault(c => c.Id == employe.Id);

            //    update.FirstName = employe.FirstName;
            //    update.LastName = employe.LastName;
            //    update.Email = employe.Email;
            //    update.PhoneNumber = employe.PhoneNumber;
            //    update.DateOfBirth = employe.DateOfBirth;
            //    update.Gender = employe.Gender;
            //    update.DrivingLicense = employe.DrivingLicense;
            //}

            _context1.SaveChanges();
            return RedirectToAction("GetMarketingEmp", "Marketing");

        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            ALS.Demo.Marketing.DataAccessLayer.Marketing marketer = _context1.Marketings.Single(c=>c.Id==id);

            if (marketer == null)
                return HttpNotFound();

            _context1.Marketings.Remove(marketer);
            _context1.SaveChanges();


            return RedirectToAction("GetMarketingEmp");


        }
        
    }

}