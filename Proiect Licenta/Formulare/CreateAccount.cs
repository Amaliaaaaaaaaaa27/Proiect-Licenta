using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.VisualBasic.ApplicationServices;

using Proiect_Licenta.Formulare;

namespace Proiect_Licenta.Formulare
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();

        }

        // sablon
        private bool VerifyIfTxtBoxIsNullOrNot(string a)
        {
            if (string.IsNullOrEmpty(a))
            {
                return false;
            }
            return true;
        }

        private bool VerifyTxtBoxIsLetterOrNot(string l)
        {
            for (int i = 0; i < l.Length; i++)
            {
                char a = l[i];

                if (!char.IsLetter(a))
                {
                    return false;
                }
            }

            return true;
        }

        User user = new User();


        public void VerifyTxtBoxNume()
        {
            user.Name = txtBoxName_CreateAccount.Text;

            if (!VerifyIfTxtBoxIsNullOrNot(user.Name))
            {
                txtBoxName_CreateAccount.Text = "EMPTY FIELD";
            }
            else if (!VerifyTxtBoxIsLetterOrNot(user.Name))
            {
                labelUserName.Text = "TYPE JUST LETTERS";
            }
        }
        public void VerifyGmail()
        {
            //findca era set private nu puteam sa citesc ! am modificat in clasa user in proprietate de la private set la set 
            user.Gmail = txtBoxGmail_CreateAccount.Text;

            if (!VerifyIfTxtBoxIsNullOrNot(user.Gmail))
            {
                txtBoxGmail_CreateAccount.Text = "EMPTY FIELD";
            }
            else if (!VerifyGmailCharacter())
            {
                labelGmail.Text = "YOUR GMAIL MUST HAVE @";
            }
        }

        public void VerifyTxtBoxPassword()
        {
            user.Password = txtBoxPassword_CreateAccount.Text;

            if (!VerifyIfTxtBoxIsNullOrNot(user.Password))
            {
                txtBoxPassword_CreateAccount.Text = "EMPTY FIELD";
            }
            else if (!LimitPassword())
            {
                labelPassword.Text = "WEAK PASSWORD";
            }
        }
        public void VerifyTxtBoxPhone()
        {
            user.Phone = txtBoxPhone_CreateAccount.Text;

            if (!VerifyIfTxtBoxIsNullOrNot(txtBoxPhone_CreateAccount.Text))
            {
                txtBoxPhone_CreateAccount.Text = "EMPTY FIELD";
            }
            else if (!LimitNumberOfPhone())
            {
                lblPhone.Text = "NUMBER OF PHONE NEED TO HAVE 10 DIGIT";
            }
        }

        private bool LimitPassword()
        {
            int length = user.Password.ToString().Length;

            if (length > 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool LimitNumberOfPhone()
        {
            int length = user.Phone.ToString().Length;

            if (length == 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool VerifyNumberOfCnp()
        {
            int length = user.CNP.ToString().Length;

            if (length == 13)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private bool VerifyGmailCharacter()
        {
            for (int i = 0; i < user.Gmail.Length; i++)
            {
                char letter = user.Gmail[i];

                if (letter == '@')
                {
                    return true;
                }
            }

            return false;
        }

        private void VerifyCNP()
        {
            user.CNP = txtBoxCNP_CreateAccount.Text;

            if (!VerifyIfTxtBoxIsNullOrNot(txtBoxCNP_CreateAccount.Text))
            {
                txtBoxCNP_CreateAccount.Text = "EMPTY FIELD";
            }
            else if (VerifyNumberOfCnp())
            {
                labelCnp.Text = "CNP NEED TO HAVE 13 DIGITS";
            }
        }

        private void VerifyCountry()
        {
            user.Country = txtBoxCountry.Text;

            if (!VerifyIfTxtBoxIsNullOrNot(txtBoxCountry.Text))
            {
                txtBoxCountry.Text = "EMPTY FIELD";
            }

        }

        private bool VerifyCond()
        {
            if (LimitNumberOfPhone() &&
                 VerifyNumberOfCnp() &&
                 VerifyGmailCharacter() &&
                 LimitPassword() &&
                 VerifyIfTxtBoxIsNullOrNot(user.Name) &&
                 VerifyIfTxtBoxIsNullOrNot(user.Gmail) &&
                 VerifyIfTxtBoxIsNullOrNot(user.Password) &&
                 VerifyIfTxtBoxIsNullOrNot(txtBoxPhone_CreateAccount.Text) &&
                 VerifyIfTxtBoxIsNullOrNot(txtBoxCNP_CreateAccount.Text) &&
                 VerifyIfTxtBoxIsNullOrNot(txtBoxCountry.Text));



            {
                return true;
            }

            return false;

        }

        private void btnExit_CA_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {

        }

        private void txtBoxName_CreateAccount_TextChanged(object sender, EventArgs e)
        {

        }

        ManagmentDataBase dataBase = new ManagmentDataBase();


        Account account = new Account();



        private void btnNext_Click(object sender, EventArgs e)
        {
            VerifyTxtBoxNume();
            VerifyGmail();
            VerifyCNP();
            VerifyTxtBoxPhone();
            VerifyTxtBoxPassword();
            VerifyCountry();


            if (VerifyCond())
            {

                ManagmentDataBase dataBase = new ManagmentDataBase();

                dataBase.SelectTableUser();

                // daca conditia de jos se indeplineste asta inseamna ca nu exista contul si ca o sa l creem
                if (!dataBase.LoginUser(user.Name, user.Password))
                {
                    dataBase.CreateAccountUser(user.Name, user.CNP, user.Gmail, user.Phone, user.Password, user.Country);
                    MessageBox.Show("Account created successfully");
                    Form Subscription = new Subscription();
                    Subscription.Show();
                    

                }
                else
                {   // in caz contrar am afisat ca contul este deja existent 
                    MessageBox.Show("Your account already exists");
                    Form Login = new Login();
                    Login.Show();
                }


            }
        }
    }

}








