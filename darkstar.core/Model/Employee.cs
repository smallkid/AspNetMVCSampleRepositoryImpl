using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace darkstar.core
{
    using System.Data.Entity;

    public class Employee
    {
        [Key]
        public string EmployeeCode { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string DepartmentCode { get; set; }
    }
}
