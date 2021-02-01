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
    /// Class to make operations categories, adding, deleting, updating categories
    /// </summary>
    public class CategoryOperations
    {
        DBContext dbCont = new DBContext();

        /// <summary>
        /// Getter method to reach categories in dbContext
        /// </summary>
        /// <returns> list of categories </returns>
        public List<Category> GetCategories()
        {
            return dbCont.Categories.ToList();
        }

        /// <summary>
        /// Getter method for category in dbContext
        /// </summary>
        /// <param name="id"> id of the category</param>
        /// <returns> category for given id</returns>
        public Category GetCategoriesById(int id)
        {
            return dbCont.Categories.Find(id);
        }

        /// <summary>
        /// Add given category object to categories
        /// </summary>
        /// <param name="categories"> category object </param>
        /// <returns></returns>
        public int AddCategory(Category category)
        {
            dbCont.Categories.Add(category);
            return dbCont.SaveChanges();
        }

        /// <summary>
        /// Delete given category from dbContex 
        /// </summary>
        /// <param name="category"> category object </param>
        /// <returns></returns>
        public int DeleteCategory(Category category)
        {
            try
            {
                if (IsCategoryExist(category) && !IsCategoryContainsProducts(category))
                {
                    dbCont.Categories.Remove(category);
                }
                else
                {
                    throw new InvalidOperationException("Category does not exists or includes products!!");
                }
            }
            catch (InvalidOperationException e)
            {

                Console.WriteLine("Deleting operation can not be completed.", e);
            }
           
            return dbCont.SaveChanges();
        }

        /// <summary>
        /// Update category in dbContext
        /// </summary>
        /// <param name="category"> category object </param>
        /// <returns></returns>
        public int UpdateCategory(Category category)
        {
            dbCont.Entry(category).State = EntityState.Modified;
            return dbCont.SaveChanges();
        }

        //HELPER METHODS

        /// <summary>
        /// Controls if a given category object is exist in dbContext
        /// </summary>
        /// <param name="category"></param>
        /// <returns> true if category exist,false otherwise</returns>
        public bool IsCategoryExist(Category category)
        {
            return dbCont.Categories.Contains(category);
        }

        /// <summary>
        /// Controls if a given category object contains any products
        /// </summary>
        /// <param name="category"></param>
        /// <returns> true if category has products, false otherwise</returns>
        public bool IsCategoryContainsProducts(Category category)
        {
            return dbCont.Categories.Find(category).Products.Any();
        }

       
    }
}
