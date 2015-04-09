using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace ProductService.Models
{
    public class ProductsContext : DbContext
    {
        public ProductsContext()
            : base("name=ProductsContext")
        {
        }
        //tuotteet
        public DbSet<Product> Products { get; set; }
        //toimittajat
        public DbSet<Supplier> Suppliers { get; set; }
        //arvostelu
        public DbSet<ProductRating> Ratings { get; set; }
    }
}