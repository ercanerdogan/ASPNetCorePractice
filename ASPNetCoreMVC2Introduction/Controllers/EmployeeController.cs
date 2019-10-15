using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNetCoreMVC2Introduction.Entities;
using ASPNetCoreMVC2Introduction.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPNetCoreMVC2Introduction.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Add()
        {

            var employeeAddViewModel = new EmployeeAddViewModel
            {
                Employee = new Employee()
            };
            return View(employeeAddViewModel);
        }

        [HttpPost]
        public IActionResult Add(Employee employee)
        {

            return View();
        }

        
    }
}