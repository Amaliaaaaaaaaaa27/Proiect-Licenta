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

        public TextBox txtBoxName_CreateAccount;
        public TextBox txtBoxGmail_CreateAccount;
        public TextBox txtBoxPassword_CreateAccount;

        public Account()
        {
            users = new List<User>();
        }


        public List<User> AdaugareUser()
        { 
            User userNew = new User()
            {
                Name = txtBoxName_CreateAccount.Text,
                Password = txtBoxPassword_CreateAccount.Text,
                Gmail = txtBoxGmail_CreateAccount.Text,


            };

            users.Add(userNew);
            return users;

        }

        public void VerifyExistAccount()
        {
            var login = users.Where(l =>l.Gmail == txtBoxGmail_CreateAccount.Text).ToList();
            if (login != null )
            {
                // exista atunci cont deci merem in Login 

                Login login1= new Login();
                login1.Show();
                
            }
        }
    }

 
}
    
