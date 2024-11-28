﻿using Microsoft.EntityFrameworkCore;
using WebApplication1.Models.Product;

namespace WebApplication1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
               : base(options)
        {
        }

        // Define DbSets for your entities
        public DbSet<Product> Products { get; set; }
    }
}
