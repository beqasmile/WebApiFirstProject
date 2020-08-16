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
    }
}
