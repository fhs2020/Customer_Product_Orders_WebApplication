using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerProductWebApplication.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [DataType(DataType.Currency)]
        public float ProductPrice { get; set; }
        public string ProductType { get; set; }
    }
}
