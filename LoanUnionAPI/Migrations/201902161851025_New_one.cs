namespace LoanUnionAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class New_one : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Customers", newName: "Customer");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Customer", newName: "Customers");
        }
    }
}
