using MVC__EmpApplication.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC__EmpApplication.Controllers
{
    public class EmployeeController : Controller
    {
        private EMPLOYEEEntities db = new EMPLOYEEEntities();
        // GET: Employee
        public ActionResult Index()
        {
            var employees = db.Employees.ToList();
            return View(employees);
        }
        //GET:Employee/Create
        public ActionResult Create()
        {
            return View();
        }
        //POST:Employee/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Employees.Add(employee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
        //GET:Employee/Edit/EMPLOYEE_ID
        public ActionResult Edit(int? EMPLOYEE_ID)
        {
            if (EMPLOYEE_ID == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(EMPLOYEE_ID);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }
        //POST:Employee/Edit/EMPLOYEE_ID
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(employee);
            }
        }
        //GET:Employee/Delete/EMPLOYEE_ID
        public ActionResult Delete(int? EMPLOYEE_ID)
        {
            if (EMPLOYEE_ID == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(EMPLOYEE_ID);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }
        //POST:Employee/Delete/EMPLOYEE_ID
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int EMPLOYEE_ID)
        {
           
            Employee employee = db.Employees.Find(EMPLOYEE_ID);

            if (employee == null)
            {
                return HttpNotFound();
            }

            db.Employees.Remove(employee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}