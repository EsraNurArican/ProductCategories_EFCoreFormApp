using Microsoft.EntityFrameworkCore;
using ProductCategories_EFCoreFormApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCategories_EFCoreFormApp.Data
{
    public class DBContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        
        /// <summary>
        /// This method will be using while creating model
        /// We have 2 tables, product and categories
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>() 
                        .HasMany(cat => cat.Products)                   // every category has many product
                        .WithOne(product => product.Category)           //every product has one category
                        .HasForeignKey(product => product.CategoryId);  //CategoryId is the foreign key between product and categories

            base.OnModelCreating(modelBuilder);
        }
        
        /// <summary>
        /// This method written to build up the database on desktop app
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Telling where to create database
            if (!optionsBuilder.IsConfigured)
            {
                // use sql server
                optionsBuilder.UseSqlServer("Server=(localdb)\\Mssqllocaldb ;Database=MiniShop ;Integrated Security=yes"); //connection string

            }
        }
    }
}
