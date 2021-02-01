using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCategories_EFCoreFormApp.Models
{
    /// <summary>
    /// Public class product, represents the properties that a product can have
    /// </summary>
    public class Product
    {
        
        public int Id { get; set; } // Id is primary key
        public string Name { get; set; }
        public string Description { get; set; }
        public double Rating { get; set; }
        public decimal Price { get; set; }
        public double Discount { get; set; }
        public string ProductInfos { get; set; }
        public Category Category { get; set; } 
        public int CategoryId { get; set; }
    }
}
