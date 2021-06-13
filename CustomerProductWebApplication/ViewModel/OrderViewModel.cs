using CustomerProductWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerProductWebApplication.ViewModel
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public int ProductId { get; set; }
        public float Amount { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Today;

        public List<Customer> CustomerList { get; set; }
        public List<Product> ProductList { get; set; }
    }
}
