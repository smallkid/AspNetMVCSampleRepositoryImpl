namespace darkstar.core.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    

    internal sealed class Configuration : DbMigrationsConfiguration<darkstar.core.CompanyCtx>
    {
        public Configuration()
        {
           // AutomaticMigrationsEnabled = false;
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(darkstar.core.CompanyCtx context)
        {
            var departments = new List<Department> 
            { 
                new Department{ Code="D01",Name="Department1"}
                ,new Department{ Code="D02",Name="Department2"}
                ,new Department{ Code="D03",Name="Department3"}
            };

            departments.ForEach(d =>
            {
                context.Departments.Add(d);
                context.SaveChanges();
            });

            var employees = new List<Employee>
            {
                 new Employee{ EmployeeCode="E001",FirstName= "Jonelle", LastName="Castaneda", DepartmentCode="D01"}
                ,new Employee{ EmployeeCode="E002",FirstName= "smallkid", LastName="smallkid" , DepartmentCode="D01"}
                ,new Employee{ EmployeeCode="E003",FirstName= "smallkid1", LastName="smallkid1", DepartmentCode="D01"}
            };

            employees.ForEach(e =>
            {
                context.Employees.Add(e);
                context.SaveChanges();
            });
        } 
    }
}
