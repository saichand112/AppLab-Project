using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ALS.Demo.Marketing.DataAccessLayer;
using ALS.Demo.Marketing.ViewModel;
using System.Data.Entity;

using System.Net;


namespace ALS.Demo.Marketing.BusinessLayer
{
   
    public class EmployeeController : Controller
    {

        private AppLabDbs _context;
        public EmployeeController()
        {
           _context = new AppLabDbs();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
    
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }



        public ActionResult GetEmployees()
        {
            var employees = _context.Employees.ToList();
           
            
            return View(employees);
        }

        public ActionResult Details(int id)
        {

            var employee = _context.Employees.SingleOrDefault(c => c.Id == id);
            if (employee == null)
                return HttpNotFound();
            return View(employee);
        }

        public ActionResult Create()
        {
            var employe = _context.Employees.ToList();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Employee employe)
        {
            if (!ModelState.IsValid)
            {
                return View("Create");
            }
            if (employe.Id == 0)
            

                _context.Employees.Add(employe);
            
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
            employe.DateCreated = DateTime.Now;
            
            _context.SaveChanges();
            return RedirectToAction("GetEmployees", "Employee");

        }


        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var employee = _context.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult SaveEditForm(Employee employe)
        {
            var update = _context.Employees.SingleOrDefault(c => c.Id == employe.Id);

            update.FirstName = employe.FirstName;
            update.LastName = employe.LastName;
            update.Email = employe.Email;
            update.PhoneNumber = employe.PhoneNumber;
            update.DateOfBirth = employe.DateOfBirth;
            update.Gender = employe.Gender;
            update.DrivingLicense = employe.DrivingLicense;

            // _context.Entry(employe).State = EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("GetEmployees");

            // return View();
        }


        //[HttpPost]
        //public ActionResult Delete(int id)
        //{
        //    Employee marketer = _context.Employees.Single(c => c.Id == id);

        //    if (marketer == null)
        //        return HttpNotFound();

        //    _context.Employees.Remove(marketer);
        //    _context.SaveChanges();


        //    return RedirectToAction("GetMarketingEmp");
        //}



        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = _context.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            //Employee employee = _context.Employees.SingleOrDefault(c => c.Id == id);
            Employee employee = _context.Employees.Find(id);
            if (employee == null)
                return HttpNotFound();

            //Employee employee = _context.Employees.Find(id);
           // AppLabContext emp = new AppLabContext();
           // emp.DeleteEmploye(id);
            
            _context.Employees.Remove(employee);
            _context.SaveChanges();


            return RedirectToAction("GetEmployees");


        }

    }

    

}
    