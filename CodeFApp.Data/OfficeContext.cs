using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace CodeFApp.Data
{
    public class OfficeContext : DbContext
    {
        public OfficeContext() : base("DefaultConnection")
        {

        }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Department> Department { get; set; }
    }
}

//=================First Step======================================
// enable-migrations  InitialCreate -ContextTypeName OfficeContext -MigrationsDirectory Migrations/SqlServerMigrations
// enable-migrations  InitialCreate -ContextTypeName MySqlOfficeContext -MigrationsDirectory Migrations/MySqlServerMigrations

//=================Second Step======================================
// add-migration  -ConfigurationTypeName CodeFApp.Data.Migrations.SqlServerMigrations.Configuration  Add_code_department_table
// add-migration  -ConfigurationTypeName CodeFApp.Data.Migrations.MySqlServerMigrations.Configuration  Add_code_department_table_mySql

//=================Third Step======================================
// update-database -ConfigurationTypeName CodeFApp.Data.Migrations.SqlServerMigrations.Configuration -verbose
// update-database -ConfigurationTypeName CodeFApp.Data.Migrations.MySqlServerMigrations.Configuration -verbose
