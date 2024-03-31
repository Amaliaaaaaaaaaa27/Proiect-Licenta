using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualBasic.ApplicationServices;

namespace Proiect_Licenta.Formulare
{
    public class LoginClass
    {
        public User user;
        //public Account account;

        public TextBox txtBoxName_CreateAccount;
        public TextBox txtBoxGmail_CreateAccount;
        public TextBox txtBoxPassword_CreateAccount;

        public LoginClass()
        {
            
        }

        Account account = new Account();
        public void VerifyIsNotExistAccount()
        {
            var log = account.users.Where(c => c.Name == txtBoxName_CreateAccount.Text && 
                                               c.Gmail == txtBoxGmail_CreateAccount.Text &&
                                               c.Password == txtBoxPassword_CreateAccount.Text).ToList();
            if (log !=null)
            {
                Form Subscription = new Subscription();
                Subscription.Show();
            }
            else
            {
                CreateAccount createAccount = new CreateAccount();
                createAccount.Show();
               
            }
        }
       


    }
}
