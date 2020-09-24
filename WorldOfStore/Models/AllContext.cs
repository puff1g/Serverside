using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorldOfStore.Models;

namespace WorldOfStore.Models
{
    public class AllContext : DbContext
    {
        public DbSet<Product> Product {get; set; }
        public DbSet<User> User { get; set; }

        public AllContext(DbContextOptions<AllContext> options)
                    : base(options)
        {
        }   
        public DbSet<WorldOfStore.Models.Order> Order { get; set; }
        public DbSet<WorldOfStore.Models.ProductVariant> ProductVariant { get; set; }

        /* protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         {
             optionsBuilder.UseSqlServer(
                "Data Source=DESKTOP-L2JTA98;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False; INITIAL CATALOG = WorldOfStore");
         }*/
    }
}
