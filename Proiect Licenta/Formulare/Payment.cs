using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
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
               VerifyNumberOfCharacter(payment.CVV, 3) &&
               VerifyIsLetterOrNot(txtBoxCardHolder.Text) &&
               VerifyNumberOfCharacter(payment.CardNumber, 16))


            {
                Form LoadingVerifyPayment = new LoadingVerifyPayment();
                LoadingVerifyPayment.Show();
            }


        }

        public PaymentClass payment { get; set; }

        public void VerifyTxtBoxCVV()
        {
            payment.CVV = txtBox_CVV.Text;


            if (VerifyIsNullTxtBox(payment.CVV))
            {
                txtBox_CVV.Text = "EMPTY FIELD";
            }
            else if (VerifyNumberOfCharacter(payment.CVV, 3))
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
            payment.CardNumber = txtBoxCardNumber.Text;

            if (VerifyIsNullTxtBox(payment.CardNumber))
            {
                txtBoxCardNumber.Text = "EMPTY FIELD";
            }
            else if (VerifyNumberOfCharacter(payment.CardNumber, 16))
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

        public bool VerifyNumberOfCharacter(string a, int b)
        {
            int counter = 0;
            for (int i = 0; i <= a.Length; i++)
            {
                char letter = a[i];

                counter++;
            }

            if (counter > b || counter < b)
            {
                return false;
            }

            return true;

        }
          
        public void Encrypt(List<int> listOfPrimeNumber, Random random)
        {
            int firstNum  = payment.Extract1NumberOfCard(payment.CardNumber);
            int secondNum = payment.Extract2NumberOfCard(payment.CardNumber);
            int thirdNum  = payment.Extract3NumberOfCard(payment.CardNumber);
            int fourthNum = payment.Extract4NumberOfCard(payment.CardNumber);
            int fifthNum = payment.Extract5NumberOfCard(payment.CardNumber);
            int sixthNum  = payment.Extract6NumberOfCard(payment.CardNumber);
            int seventhNum= payment.Extract7NumberOfCard(payment.CardNumber);
            int eighthNum = payment.Extract8NumberOfCard(payment.CardNumber);
            int ninthNum = payment.Extract9NumberOfCard(payment.CardNumber);
            int tenthNum = payment.Extract10NumberOfCard(payment.CardNumber);
            int eleventhNum = payment.Extract11NumberOfCard(payment.CardNumber);
            int tweltfNum  = payment.Extract12NumberOfCard(payment.CardNumber);
            int thirteenthNum =  payment.Extract13NumberOfCard(payment.CardNumber);
            int fourteenthNum = payment.Extract14NumberOfCard(payment.CardNumber);
            int fifteenthNum = payment.Extract15NumberOfCard(payment.CardNumber);
            int sixteenthNum = payment.Extract16NumberOfCard(payment.CardNumber);

            payment.AddNumberInList(listOfPrimeNumber);
            payment.LargePrimeNumber(listOfPrimeNumber);
           int p =  payment.RandomNumbersP(listOfPrimeNumber, random);
           int q =  payment.RandomNumbersQ(listOfPrimeNumber, random);
           int n =  payment.MultiplicationLargeNumber(p,q);
           int r = payment.FindR(p,q);
           int e = payment.E();
           int ciphertext1 = payment.Encrypt(firstNum,e,n);
           int ciphertext2 = payment.Encrypt(secondNum,e,n);
           int ciphertext3 = payment.Encrypt(thirdNum,e,n);
           int chipertext4 = payment.Encrypt(fourthNum,e,n);
           int chipertext5 = payment.Encrypt(fifthNum,e,n);
           int chipertext6 = payment.Encrypt(sixthNum,e,n);
           int chipertext7 = payment.Encrypt(seventhNum,e,n);
           int chipertext8 = payment.Encrypt(eighthNum,e,n);
           int chipertext9 = payment.Encrypt(ninthNum,e,n);
           int chipertext10 = payment.Encrypt(tenthNum,e,n);
           int chipertext11 = payment.Encrypt(eleventhNum,e,n);
           int chipertext12 = payment.Encrypt(tweltfNum,e,n);
           int chipertext13 = payment.Encrypt(thirteenthNum,e,n);
           int chipertext14 = payment.Encrypt(fourteenthNum,e,n);
           int chipertext15 = payment.Encrypt(fifteenthNum,e,n);
           int chipertext16 = payment.Encrypt(sixteenthNum,e,n);

        }

    }

}







