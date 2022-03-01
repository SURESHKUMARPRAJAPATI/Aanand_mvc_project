using Aanand_mvc_project.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aanand_mvc_project.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext dbContext;
        public CustomerController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult Index()
        {
            List<Customer> cus = dbContext.customers.ToList();
            return View(cus);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Customer cus)
        {
            dbContext.customers.Add(cus);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var cus = dbContext.customers.SingleOrDefault(e => e.Id == id);
            if (cus != null)
            {
                dbContext.customers.Remove(cus);
                dbContext.SaveChanges();
                return RedirectToAction("index");
            }
            else
            {
                return RedirectToAction("index");
            }
        }

        public IActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Edit(Customer cus)
        {
            dbContext.customers.Update(cus);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }

}
