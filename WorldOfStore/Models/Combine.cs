using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorldOfStore.Models
{
    public class Combine : DbContext
    {
        public DbSet<product> Products {get; set; }
        public DbSet<User> Users { get; set; }
    }
}
