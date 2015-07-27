using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace darkstar.core
{
    public class EmployeeRepository : EFRepository<Employee, string>, IEmployeeRepository
    {
        public EmployeeRepository(DbContext ctx) : base(ctx)
        {
        }
    }
}
