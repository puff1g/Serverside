﻿using System;
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
        public string Pris {get; set;}
        public string Amount {get; set;}
    }
}
