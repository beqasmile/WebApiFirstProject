using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.UI.WebControls.WebParts;

namespace ProductsApp.Models
{
    public class CustomerModel
    {
        private static CustomerModel instance;

        private List<Customer> customers;

        public List<Customer> Customers { get => customers; set => customers = value; }

        public static CustomerModel GetCustomers()
        {
            if (instance== null)
            {
                instance = new CustomerModel();
            }
            return instance;
        }


        public CustomerModel()
        {

            this.Customers = new List<Customer>()
            {
                new Customer() {Id=1, Name="Moshe", Family="Kolnov", Address="Beer Sheva", Phone="444555666"},
                new Customer() {Id=2, Name="Lea", Family="Krat", Address="Beer Sheva", Phone="121222"}
            };
        


        }
    }
}