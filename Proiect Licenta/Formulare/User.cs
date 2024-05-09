using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualBasic;

namespace Proiect_Licenta.Formulare
{
    public class User
    {
        public int ID { get; }

        // cnp si nr of phone it s string because i dont use this for some math stuf 
        private static int contIDGenerator = 0;
        public string Name { get;  set; }
        public  string  CNP { get;  set; }
        public string Gmail { get;  set; }
        public string  Phone { get;  set; }
        public string Password { get;  set; }
        public string Country { get; set; }

     


        public User()
        {
            ID = contIDGenerator++;
           
        }
        public int ExtractDataFromCnp(string cnp)
        {
            string bornDate = cnp.Substring(1, 13);
            int year = int.Parse(bornDate.Substring(1,2));

            if(year >= 0 && year <= 21)
        {
                year += 2000;
            }
            else
            {
                year += 1900;
            }

            return year;
        }

       
        

    }

}


