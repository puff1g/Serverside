using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace WorldOfStore.Models
{
    public class productsContext : DbContext
    {
            public productsContext(DbContextOptions<productsContext> options)
                    : base(options)
            {
            }

            public DbSet<product> Product {get; set;}
        }
}
