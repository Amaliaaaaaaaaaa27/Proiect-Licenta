using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.VisualBasic.ApplicationServices;

namespace Proiect_Licenta.Formulare
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

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

        public User user { get; set; }


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
            int numberOfPhone;

            if (int.TryParse(txtBoxPhone_CreateAccount.Text, out numberOfPhone))
            {
                user.Phone = numberOfPhone;
            }

            else if (!VerifyIfTxtBoxIsNullOrNot(txtBoxPhone_CreateAccount.Text))
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

            if (length == 12)
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
            int cnp;

            if (int.TryParse(txtBoxCNP_CreateAccount.Text, out cnp))
            {
                user.CNP = cnp;
            }
            else if (!VerifyIfTxtBoxIsNullOrNot(txtBoxCNP_CreateAccount.Text))
            {
                txtBoxCNP_CreateAccount.Text = "EMPTY FIELD";
            }
            else if (VerifyNumberOfCnp())
            {
                labelCnp.Text = "CNP NEED TO HAVE 13 DIGITS";
            }
        }

        private void btn_Next_Click_1(object sender, EventArgs e)
        {
            VerifyTxtBoxPassword();
            VerifyGmail();
            VerifyTxtBoxPhone();
            VerifyTxtBoxNume();
            VerifyCNP();

            if (LimitNumberOfPhone() &&
                VerifyNumberOfCnp() &&
                VerifyGmailCharacter() &&
                LimitPassword() &&
                VerifyIfTxtBoxIsNullOrNot(user.Name) &&
                VerifyIfTxtBoxIsNullOrNot(user.Gmail) &&
                VerifyIfTxtBoxIsNullOrNot(user.Password) &&
                VerifyIfTxtBoxIsNullOrNot(txtBoxPhone_CreateAccount.Text) &&
                VerifyIfTxtBoxIsNullOrNot(txtBoxCNP_CreateAccount.Text))

            {
                Form Subscription = new Subscription();
                Subscription.Show();
            }
            else
            {
                return;
            }


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
    }

}
