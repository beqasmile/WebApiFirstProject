using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace ProductsApp.Models
{
    public class ProductsModel
    {
        private List<Product> products;

        public static ProductsModel _instance;

        public List<Product> Products { get => products; set => products = value; }

        public ProductsModel()
        {
            this.Products = new List<Product>() {
                new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 },
                new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M },
                new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M }
            };
        }

        public static ProductsModel GetProducts()
        {
            if (_instance == null)
            {
                _instance = new ProductsModel();
            }

            return _instance;
        }





    }
}