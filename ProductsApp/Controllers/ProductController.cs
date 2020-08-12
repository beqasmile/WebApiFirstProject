using ProductsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProductsApp.Controllers
{
    public class ProductController : ApiController
    {
        //Product[] products = new Product[]
        //{
        //    new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 },
        //    new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M },
        //    new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M }
        //};

        [HttpGet]
        [ActionName("GetAllProducts")]
        public HttpResponseMessage GetAllProductsHTTP()
        {
            HttpResponseMessage httpResponseMessage = Request.CreateResponse(HttpStatusCode.OK, ProductsModel.GetProducts().Products);

            return httpResponseMessage;
        }
 


        [HttpPost]
        [ActionName("AddProduct")]
        public IHttpActionResult AddProduct(Product product)
        {
            if (product != null)
            {
                var existProduct = ProductsModel.GetProducts().Products.FirstOrDefault(p => p.Id == product.Id);
                if (existProduct != null)
                {
                    throw new Exception("Product already exists");
                }
                ProductsModel.GetProducts().Products.Add(product);
                return Ok(product);
            }
            return NotFound();
            
        }

        [HttpGet]
        [ActionName("GetProductById")]
        public IHttpActionResult GetProductById(int id)
        {
            var product = ProductsModel.GetProducts().Products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                throw new Exception("Product doesnot exists");
            }
            return Ok(product);
        }



    }
}
