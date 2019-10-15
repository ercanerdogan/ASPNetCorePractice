using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNetCoreMVC2Introduction.Entities;
using ASPNetCoreMVC2Introduction.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ASPNetCoreMVC2Introduction.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Add()
        {

            var employeeAddViewModel = new EmployeeAddViewModel
            {
                Employee = new Employee(),
                Cities = new List<SelectListItem>
                {
                    new SelectListItem {Text="Izmir", Value = "35"},
                    new SelectListItem {Text="Istanbul", Value="34"},
                    new SelectListItem {Text="Ankara", Value="06"}
                }
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