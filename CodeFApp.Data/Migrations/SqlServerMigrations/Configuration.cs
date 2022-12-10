namespace CodeFApp.Data.Migrations.SqlServerMigrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.SqlServer;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CodeFApp.Data.OfficeContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations/SqlServerMigrations";
            SetSqlGenerator("System.Data.SqlClient", new SqlServerMigrationSqlGenerator());
        }

        protected override void Seed(CodeFApp.Data.OfficeContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
