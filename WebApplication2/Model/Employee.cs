using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Model
{
    public class Employee
    {        
        public int EmployeeID { get; set; }
        public string EmployeeLastName { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeePhone { get; set; }
        public string EmployeeZip { get; set; }
        public DateTime EmployeeHireDate { get; set; }

    }


}