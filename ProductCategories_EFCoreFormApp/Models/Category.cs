using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCategories_EFCoreFormApp.Models
{
    /// <summary>
    /// Category class written to represent product's category
    /// </summary>
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        // One category can have many products
        // Navigation property..
        public IList<Product> Products { get; set; }
    }
}
