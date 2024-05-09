using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Licenta.Formulare
{
   
      public class Account
     {
        public User user { get; set; }
        public List<User> users { get; set; }

        public Account()
        {
            users = new List<User>();
        }


      }

 
}
    
