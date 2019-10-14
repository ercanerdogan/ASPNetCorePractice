using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNetCoreMVC2Introduction.Entities;
using ASPNetCoreMVC2Introduction.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPNetCoreMVC2Introduction.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello from first Application";
        }

        public ViewResult Index2()
        {
            return View();
           
        }

        public ViewResult Index3()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee{ID=1, FirstName ="Ercan", LastName ="Erdogan", CityID=35 },
                new Employee{ID=2, FirstName ="Hakan", LastName ="Erdogan", CityID=35 }

            };

            List<string> cities = new List<string> { "Istanbul", "Izmir", "Ankara" };

            var model = new EmployeeListViewModel
            {
                Employees = employees,
                Cities = cities

            };

            return View(model);


        }

        public StatusCodeResult Index4()
        {
            return NotFound();
        }

        public StatusCodeResult Index5()
        {
            return Ok();
        }

        public RedirectResult Index6()
        {
            return Redirect("Home/Index4");
        }

        public IActionResult Index7()
        {
            return RedirectToAction("Index3");
        }

        public JsonResult Index8()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee{ID=1, FirstName ="Ercan", LastName ="Erdogan", CityID=35 },
                new Employee{ID=2, FirstName ="Hakan", LastName ="Erdogan", CityID=35 }

            };

            return Json(employees);

        }

        public IActionResult Index10()
        {
            return RedirectToAction("Index5");
        }

        public JsonResult Index11(string pName)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee{ID=1, FirstName ="Ercan", LastName ="Erdogan", CityID=35 },
                new Employee{ID=2, FirstName ="Hakan", LastName ="Erdogan", CityID=35 }

            };

            if (String.IsNullOrEmpty(pName))
            {
                return Json(employees);
            }

            var result = employees.Where(e => e.FirstName.ToLower().Contains(pName));
            
            return Json(result);


        }
    }
}
