using DotNetDrinks.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetDrinks.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        //Declare all the brand models so the db can work with it and so can the rest of our app
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categroies { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orderss { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Cart> Carts { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
