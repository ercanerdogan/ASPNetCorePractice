using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCoreMVC2Introduction.Entities
{
    public class Employee
    {
        public int ID { get; set; }
        [Display(Name="First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "City")]
        public int CityID{ get; set; }
    }
}
