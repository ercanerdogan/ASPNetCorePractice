using System.Collections.Generic;
using ASPNetCoreMVC2Introduction.Entities;

namespace ASPNetCoreMVC2Introduction.Models
{
    public class EmployeeListViewModel
    {
        public List<Employee> Employees { get; set; }
        public List<string> Cities { get; set; }
    }
}