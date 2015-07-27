using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;


namespace darkstar.core
{
    public class Department
    {
        [Key]
        public string Code { get; set; }
        public string Name { get; set; }
        public IList<Employee> Employees { get; set; }
    }
}
