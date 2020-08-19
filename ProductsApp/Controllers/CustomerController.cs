using ProductsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProductsApp.Controllers
{
    public class CustomerController : ApiController
    {

        [HttpGet]
        [ActionName("GetAllCustomers")]
        public HttpResponseMessage GetAllCustomers()
        {
            HttpResponseMessage httpResponseMessage = Request.CreateResponse(HttpStatusCode.OK, CustomerModel.GetCustomers().Customers);

            return httpResponseMessage;
        }

        [HttpPost]
        [ActionName("AddCustomer")]
        public IHttpActionResult AddCustomer(Customer customer)
        {
            if (customer != null)
            {
                var existCustomer = CustomerModel.GetCustomers().Customers.FirstOrDefault(p => p.Id == customer.Id);
                if (existCustomer != null)
                {
                    throw new Exception("Customer already exists");
                }
                CustomerModel.GetCustomers().Customers.Add(customer);
                return Ok(customer);
            }
            return NotFound();

        }
    }
}
