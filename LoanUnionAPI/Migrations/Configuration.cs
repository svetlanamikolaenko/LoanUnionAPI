namespace LoanUnionAPI.Migrations
{
    using LoanUnionAPI.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LoanUnionAPI.Data.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LoanUnionAPI.Data.AppDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Customers.Add(new Customer() { FirstName = "Svitlana", LastName = "Mykolaienko", Email = "svetlana.mikolaenko@gmail.com", FathersName = "Anatoliyivna", PhoneNumber = "+380991112222", DateOfBirth = DateTime.Parse("1985-05-05"), PassportNumber = "ММ11111", PassportGivenByWhom = "Києво-Святошинським РВ ГУ МВС України", UniqueCode = 12345678912, Salary = 8000, PassportGivenDate = DateTime.Parse("01.05.2000") });
        }
    }
}
