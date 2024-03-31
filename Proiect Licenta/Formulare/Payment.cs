using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Proiect_Licenta.Formulare;

namespace Proiect_Licenta
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();

            txtBoxCardNumber.TextChanged += EventHandler;
            txtBoxCardHolder.TextChanged += EventHandler;
            txtBox_MM.TextChanged += EventHandler;
            txtBox_YYYY.TextChanged += EventHandler;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Payment_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void EventHandler(object sender, EventArgs e)
        {
            lblName_Payment.Text = $"{txtBoxCardHolder.Text}";
            lblExp_Payment.Text = $"{txtBox_MM.Text} / {txtBox_YYYY.Text}";
            lbl_NumberCard.Text = $"{txtBoxCardNumber.Text}";

        }

        private void Payment_Load(object sender, EventArgs e)
        {

        }

        private void btn_PAY_Click(object sender, EventArgs e)
        {

            if (VerifyIsNullTxtBox(txtBoxCardNumber.Text) &&
               VerifyIsNullTxtBox(txtBox_CVV.Text) &&
               VerifyIsNullTxtBox(txtBoxCardHolder.Text) &&
               VerifyCVVLength(payment.CVV) &&
               VerifyIsLetterOrNot(txtBoxCardHolder.Text) &&
               VerifyNumberCardLength(payment.CardNumber))
            {
                Form LoadingVerifyPayment = new LoadingVerifyPayment();
                LoadingVerifyPayment.Show();
            }

          
        }

        public PaymentClass payment { get; set; }

        public void VerifyTxtBoxCVV()
        {
            int cvv;

            if (int.TryParse(txtBox_CVV.Text, out cvv))
            {
                payment.CVV = cvv;
            }
            else if (VerifyIsNullTxtBox(txtBox_CVV.Text))
            {
                txtBox_CVV.Text = "EMPTY FIELD";
            }
            else if (!VerifyCVVLength(payment.CVV))
            {
                lblVerifyCVV.Text = "CVV NEED TO \n JUST 3 DIGITS";
            }

        }

        public void VerifyTxtBoxNameCardHolder()
        {
            payment.CardHolder = txtBoxCardHolder.Text;

            if (VerifyIsLetterOrNot(txtBoxCardHolder.Text))
            {
                lblVerifyCardHolder.Text = "NEED TO HAVE LETTERS";
            }
            else if (VerifyIsNullTxtBox(txtBoxCardHolder.Text))
            {
                txtBoxCardHolder.Text = "EMPTY FIELD";
            }
        }

        public void VerifyTxtBoxCardNumber()
        {
            int cardNumber;

            if (int.TryParse(txtBoxCardNumber.Text, out cardNumber))
            {
                payment.CardNumber = cardNumber;
            }
            else if (VerifyIsNullTxtBox(txtBoxCardNumber.Text))
            {
                txtBoxCardNumber.Text = "EMPTY FIELD";
            }
            else if (!VerifyNumberCardLength(payment.CardNumber))
            {
                labelCardHolderVerify.Text = "NUMBER CARD NEED TO HAVE 16 DIGITS ";
            }

        }

        public bool VerifyIsLetterOrNot(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                char a = s[i];

                if (!char.IsLetter(a))
                {
                    return false;
                }

            }

            return true;
        }



        public bool VerifyIsNullTxtBox(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return false;
            }
            else
            {
                return true;
            }


        }

        public bool VerifyNumberCardLength(int a)
        {
            int lenght = a.ToString().Length;

            if (lenght == 16)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool VerifyCVVLength(int a)
        {
            int lenght = a.ToString().Length;

            if (lenght == 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }

}