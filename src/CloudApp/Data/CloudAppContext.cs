using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CloudApp.Models;

namespace CloudApp.Data
{
    public class CloudAppContext : DbContext
    {
        public CloudAppContext (DbContextOptions<CloudAppContext> options)
            : base(options)
        {
        }

        public DbSet<CloudApp.Models.Product> Product { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>(entity => 
                entity.Property(x=>x.Price).HasPrecision(18, 2));
        }
    }
}
