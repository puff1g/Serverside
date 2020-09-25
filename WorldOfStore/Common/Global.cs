using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorldOfStore.Models;

namespace WorldOfStore.Common
{
    public static class Global
    {
        public static List<User> Users { get; set; } = new List<User>();
    }
}
