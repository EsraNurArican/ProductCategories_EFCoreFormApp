using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductCategories_EFCoreFormApp.Data;
using ProductCategories_EFCoreFormApp.Models;

namespace ProductCategories_EFCoreFormApp.Services
{
    /// <summary>
    /// Class to make product operations such as adding,deleting products or updating product information
    /// </summary>
    public class ProductOperations
    {
        DBContext dbCont = new DBContext();

        /// <summary>
        /// Get products in dbContext
        /// </summary>
        /// <returns> list of products</returns>
        public List<Product> GetProducts()
        {
            return dbCont.Products.ToList();
        }

        /// <summary>
        /// Get product by its id
        /// </summary>
        /// <param name="id">product id</param>
        /// <returns> product </returns>
        public Product GetProduct(int id)
        {
            return dbCont.Products.Find(id);
        }

        /// <summary>
        /// Returns a list of products for a specific category
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns> list of products </returns>
        public List<Product> GetProductsByCategory(int categoryId)
        {
            var products = dbCont.Products.Select(p => new Product()
            {
                Id = p.Id,
                Name = p.Name,
                Description = p.Description,
                Rating=p.Rating,
                Price = p.Price,
                Discount=p.Discount,
                ProductInfos=p.ProductInfos,
                CategoryId = p.Category.Id,
                Category = p.Category
            }).Where(a => a.CategoryId == categoryId).ToList();
            return products;
        }

       /// <summary>
       /// Add new product to dbcontext products
       /// </summary>
       /// <param name="products"></param>
        public void AddProduct(Product products)
        {
            
            dbCont.Products.Add(products);
            dbCont.SaveChanges();
        }

        /// <summary>
        /// Update product information
        /// </summary>
        public void UpdateProduct(Product products)
        {
            dbCont.Entry(products).State = EntityState.Modified;
            dbCont.SaveChanges();
        }

        /// <summary>
        /// Delete given product
        /// </summary>
        /// <param name="products"></param>
        public void DeleteProduct(Product products)
        {
            dbCont.Products.Remove(products);
            dbCont.SaveChanges();
        }



    }
}
