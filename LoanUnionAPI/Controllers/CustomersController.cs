using LoanUnionAPI.Data;
using LoanUnionAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace LoanUnionAPI.Controllers
{
    [EnableCors("http://localhost:4200", "*", "*")]
    public class CustomersController : ApiController
    {
        public IHttpActionResult GetCustomer(int id)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var customer = context.Customers.FirstOrDefault(n =>n.Id ==id);
                    if (customer == null) return NotFound();
                    return Ok(customer);
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        public IHttpActionResult GetCustomers()
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var customers = context.Customers.ToList();
                    return Ok(customers);
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPost]
        public IHttpActionResult PostCustomer ([FromBody]Customer customer)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            try
            {
                using (var context = new AppDbContext())
                {
                    context.Customers.Add(customer);
                    context.SaveChanges();
                    return Ok("Customer was created!");
                }
            }
            catch (Exception ex)
            {
                    return BadRequest (ex.Message);
            }
        }
        [HttpPut]
        public IHttpActionResult UpdateCustomer(int id, [FromBody]Customer customer)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (id != customer.Id) return BadRequest();
            
            try
            {
                using (var context = new AppDbContext())
                {
                    var oldCustomer = context.Customers.FirstOrDefault(n => n.Id == id);
                    if (oldCustomer == null) return NotFound();
                    oldCustomer.FirstName = customer.FirstName;
                    oldCustomer.LastName = customer.LastName;
                    oldCustomer.PassportGivenByWhom = customer.PassportGivenByWhom;
                    oldCustomer.PassportGivenDate = customer.PassportGivenDate;
                    oldCustomer.PassportNumber = customer.PassportNumber;
                    oldCustomer.PhoneNumber = customer.PhoneNumber;
                    oldCustomer.Salary = customer.Salary;
                    oldCustomer.Email = customer.Email;
                    oldCustomer.FathersName = customer.FathersName;
                    context.SaveChanges();
                    return Ok("Customer updated!");
                }
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

                      
 
        }

        [HttpDelete]
        public IHttpActionResult DeleteCustomer(int id)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var customer = context.Customers.FirstOrDefault(n => n.Id == id);
                    if (customer == null) return NotFound();

                    context.Customers.Remove(customer);
                    context.SaveChanges();

                    return Ok("Customer deleted");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}

