using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorldOfStore.Models
{
    public class Product
    {
        public long ProductID {get; set;}
        public string Name {get; set;}
        public string Description {get; set;}
        public int Pris {get; set;}
        public int Amount {get; set;}
        public virtual List<Product> Products { get; set; }
    }
}
