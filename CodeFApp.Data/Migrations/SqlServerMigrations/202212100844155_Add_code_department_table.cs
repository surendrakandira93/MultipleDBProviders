namespace CodeFApp.Data.Migrations.SqlServerMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_code_department_table : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Departments", "Code", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Departments", "Code");
        }
    }
}
