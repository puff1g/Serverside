using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorldOfStore.Models
{
    public class User
    {
        public long UserID { get; set; }
        public string UserName  {get; set; }
        public string UserMail  {get; set; }
        public Boolean IsAdmin { get; set; }
         
        public virtual List<User> Users { get; set; }
    }
}
