using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace darkstar.core
{
    public class CompanyCtx : DbContext 
    {

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public CompanyCtx() : base("darkstar")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
