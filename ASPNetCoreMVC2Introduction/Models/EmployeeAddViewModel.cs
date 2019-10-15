using System.Collections.Generic;
using ASPNetCoreMVC2Introduction.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ASPNetCoreMVC2Introduction.Models
{
    public class EmployeeAddViewModel
    {
        public Employee Employee { get; set; }
        public List<SelectListItem> Cities { get;  set; }
    }
}