using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Proiect_Licenta.Formulare
{
    public partial  class PaymentClass
    {
        public Guid ID;
        public string CardNumber { get; set; }
        public string  CVV { get; set; }
        public string Exp { get; set; }
        public string CardHolder { get; set; }

        public PaymentClass()
        {
            ID = new Guid();
        }

        public int Extract1NumberOfCard(string CardNumber)
        {
            string cardNumber = CardNumber.Substring(1, 16);
            int firstNumberCard = int.Parse(cardNumber.Substring(0, 1));
            return firstNumberCard;
        }
        public int Extract2NumberOfCard(string cardNumber)
        {
            int secondNumberCard = int.Parse(cardNumber.Substring(1, 1));
            return secondNumberCard;
        }
        public int Extract3NumberOfCard(string cardNumber)
        {
            int thirdNumberCard = int.Parse(cardNumber.Substring(2, 1));
            return thirdNumberCard;
        }
        public int Extract4NumberOfCard(string cardNumber)
        {
            int fourthNumberCard = int.Parse(cardNumber.Substring(3, 1));
            return fourthNumberCard;
        }
        public int Extract5NumberOfCard(string cardNumber)
        {

            int fifthNumberCard = int.Parse(cardNumber.Substring(4, 1));
            return fifthNumberCard;
        }
        public int Extract6NumberOfCard(string cardNumber)
        {
            int sixthNumberCard = int.Parse(cardNumber.Substring(4, 1));
            return sixthNumberCard;
        }
        public int Extract7NumberOfCard(string cardNumber)
        {
            int seventhNumberCard = int.Parse(cardNumber.Substring(5, 1));
            return seventhNumberCard;
        }
        public int Extract8NumberOfCard(string cardNumber)
        {
            int eighthNumberCard = int.Parse(cardNumber.Substring(6, 1));
            return eighthNumberCard;
        }
        public int Extract9NumberOfCard(string cardNumber)
        {
            int ninthNumberCard = int.Parse(cardNumber.Substring(7, 1));
            return ninthNumberCard;
        }
        public int Extract10NumberOfCard(string cardNumber)
        {
            int tenthNumberCard = int.Parse(cardNumber.Substring(9, 1));
            return tenthNumberCard;
        }
        public int Extract11NumberOfCard(string cardNumber)
        {
            int eleventhNumberCard = int.Parse(cardNumber.Substring(10, 1));
            return eleventhNumberCard;
        }
        public int Extract12NumberOfCard(string cardNumber)
        {
            int twelfthNumberCard = int.Parse(cardNumber.Substring(11, 1));
            return twelfthNumberCard;
        }
        public int Extract13NumberOfCard(string cardNumber)
        {
            int thirteenthNumberCard = int.Parse(cardNumber.Substring(12, 1));
            return thirteenthNumberCard;
        }
        public int Extract14NumberOfCard(string cardNumber)
        {
            int fourteenthNumberCard = int.Parse(cardNumber.Substring(13, 1));
            return fourteenthNumberCard;
        }
        public int Extract15NumberOfCard(string cardNumber)
        {
            int fifteenthNumberCard = int.Parse(cardNumber.Substring(14, 1));
            return fifteenthNumberCard;
        }
        public int Extract16NumberOfCard(string cardNumber)
        {
            int sixteenthNumberCard = int.Parse(cardNumber.Substring(15, 1));
            return sixteenthNumberCard;
        }

       public  List<int> listOfPrimeNumber = new List<int>();

       public  Random random = new Random();

        // inainte era public  static si nu puteam sa vad metoda si daca o apelam 
        public  void AddNumberInList(List<int> listOfPrimeNumber)
        {
            for (int i = 2; i <= 12; i++)
            {
                listOfPrimeNumber.Add(i);
            }
        }
        //cirul Erestone
        public  void LargePrimeNumber(List<int> listOfPrimeNumber)
        {     // need to be prime number
            for (int i = 2; i <= listOfPrimeNumber.Count - 1; i++)
            {
                if (listOfPrimeNumber[i] % 2 == 1)
                {

                    for (int j = listOfPrimeNumber.Count - 1; j >= 2; j--)
                    {     //10%5
                        if (listOfPrimeNumber[j] % listOfPrimeNumber[i] == 0)
                        {
                            listOfPrimeNumber.Remove(listOfPrimeNumber[i]);
                        }
                    }
                }

            }

        }

        public  int RandomNumbersQ(List<int> listOfPrimeNumber, Random random)
        {
            int p = random.Next(2, listOfPrimeNumber.Count);

            return p;
        }
        public  int RandomNumbersP(List<int> listOfPrimeNumber, Random random)
        {
            int q = random.Next(2, listOfPrimeNumber.Count);

            return q;
        }

        public  int MultiplicationLargeNumber(int p, int q)
        {
            int n = p * q;
            return n;
        }
        public  int FindR(int p, int q)
        {
            int r = (p - 1) * (q - 1);
            return r;
        }
        public int E()
        {
            int e = 3;
            return e;
        }
        //public static int  FindD(int e, int r, int d, int n)
        //{
        //    //d*e mod(n) = 1

        //}
        public  int Encrypt(int numberOfCard , int e, int n)
        {
            int c = (int)Math.Pow(numberOfCard, e) % n; //ciphrtyext
            //cred ca o sa fac o lista sa stochez toate numerele criptate
            return c;
        }
        //public static void Decrypt(double c, int d, int n)  // c^d mod(n)
        //{
        //    double decrypt = Math.Pow(c, d) % n;
        //    Console.WriteLine(decrypt);
        //}

    }
}

