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

        private static int contIDGenerator = 0;
        public string Name { get;  set; }
        public  int CNP { get;  set; }
        public string Gmail { get;  set; }
        public int Phone { get;  set; }
        public string Password { get;  set; }
        public string City { get; set; }
        public string Country { get; set; }

        public string Municipality { get; set; }


        public User()
        {
            ID = contIDGenerator++;
           
        }

        // 6020927170081
        // 0123456789101112
        public  void ExtractDataFromCnp(string cnp)
        {
            string bornDate = cnp.Substring(1, 13);
            int month = int.Parse(bornDate.Substring(3, 4));
            int day = int.Parse(bornDate.Substring(5,6));
            int year = int.Parse(bornDate.Substring(2,2));

            if(year >= 0 && year <= 21)
        {
                year += 2000;
            }
            else
            {
                year += 1900;
            }

          DateTime born  = new DateTime(year, month , day);
        }

      

    }

}


