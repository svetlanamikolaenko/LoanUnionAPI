﻿using LoanUnionAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LoanUnionAPI.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext() : base("name=LoanUnionDb")
        {

        }
        public DbSet<Customer> Customers { get; set; }
    }
}