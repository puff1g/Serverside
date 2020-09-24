using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorldOfStore.Models
{
    public class ProductVariant
    {
        public long Id { get; set; }
        public string Difficulty { get; set; }
        public int Price { get; set; }
        public virtual List<ProductVariant> ProductVariants { get; set; }
    }
}
