namespace LoanUnionAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        FathersName = c.String(),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                        UniqueCode = c.Long(nullable: false),
                        PassportNumber = c.String(),
                        PassportGivenByWhom = c.String(),
                        PassportGivenDate = c.DateTime(nullable: false),
                        DateOfBirth = c.DateTime(nullable: false),
                        Salary = c.Double(nullable: false),
                        ScanCopy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Customers");
        }
    }
}
