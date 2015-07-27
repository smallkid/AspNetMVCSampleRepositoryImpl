using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace darkstar.core
{
    public interface IEmployeeRepository : IEFRepository<Employee,string>
    {
    }
}
