﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorldOfStore.Models
{
    public class product
    {
        public long Id {get; set;}
        public string Name {get; set;}
        public string Description {get; set;}
        public int Pris {get; set;}
        public int Amount {get; set;}

        public virtual List<product> Products { get; set; }
    }
}
