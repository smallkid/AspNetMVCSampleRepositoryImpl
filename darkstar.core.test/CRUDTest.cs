using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using darkstar.core;

namespace darkstar.core.test
{
    [TestClass]
    public class CRUDTest
    {
        [TestMethod]
        public void AddEmployee()
        {
            var ctx = new CompanyCtx();

            var employeeRepo = new EmployeeRepository(ctx);
            var e1 = new Employee { EmployeeCode = "E88", FirstName = "Jonelle", LastName = "Castaneda",DepartmentCode="D01" };
            employeeRepo.Add(e1);
        }
    }
}
