using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorldOfStore.Models
{
    public class Order
    {
        public long OrderId { get; set; }
        public string KundeID { get; set; }
        public DateTime Date { get; set; }
        public string Product { get; set; } // Add total
    }
}
