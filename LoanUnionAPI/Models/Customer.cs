using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LoanUnionAPI.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FathersName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public long UniqueCode { get; set; }
        public string PassportNumber { get; set; }
        public string PassportGivenByWhom { get; set; }
        public DateTime PassportGivenDate { get; set; }
        public DateTime DateOfBirth { get; set; }
        public double Salary { get; set; }
        public string ScanCopy { get; set; }
    }
}