using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CustomerProductWebApplication.Models;

namespace CustomerProductWebApplication.Data
{
    public class CustomerProductWebApplicationContext : DbContext
    {
        public CustomerProductWebApplicationContext (DbContextOptions<CustomerProductWebApplicationContext> options)
            : base(options)
        {
        }
        public DbSet<CustomerProductWebApplication.Models.Customer> Customer { get; set; }
        public DbSet<CustomerProductWebApplication.Models.Product> Product { get; set; }
        public DbSet<CustomerProductWebApplication.Models.Stock> Stock { get; set; }
        public DbSet<CustomerProductWebApplication.Models.Order> Order { get; set; }

       
    }
}
