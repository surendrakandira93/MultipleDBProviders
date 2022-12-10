namespace CodeFApp.Data.Migrations.MySqlServerMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_code_department_table_mySql : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Departments", "Code", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Departments", "Code");
        }
    }
}
