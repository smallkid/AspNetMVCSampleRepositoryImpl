using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace darkstar.core
{
    using System.Data.Entity;
    public class DepartmentRepository : EFRepository<Department,string>, IDepartmentRepository
    {
        public DepartmentRepository(DbContext ctx) :base(ctx)
        {
        }
    }
}
