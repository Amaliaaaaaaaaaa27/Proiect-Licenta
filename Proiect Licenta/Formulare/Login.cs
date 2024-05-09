using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;

using Microsoft.VisualBasic;

using Proiect_Licenta.Formulare;

using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Proiect_Licenta
{

     
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        ManagmentDataBase dataBase = new ManagmentDataBase();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // am folosit using si am scris conexiune inauntr ul blocului pentru a ma asigura ca conexiunea este inchisa automat dupa iesirea din bloc 

            //cu aceasta metoda am creat tabelul users acum dupa ce l am creat il bagam sub comentariu ca sa nu se creeze iar un alt tabel
            //dataBase.CreateTableUser();

            // am uitat sa creez un tabel asadar am modificat cu ajutorul lui ALTER TABLE am apelat metoda pt a se crea o coloana in tabelul respectiv am rulat app dupa am pus in comentariu deoarece trebuie o unica coloana nu pot sa creea ceea coloana din nou
            //dataBase.ModifyTableUser();

            dataBase.SelectTableUser();
            
            //
            if (dataBase.LoginUser(gunaTextBoxUserName.Text, gunaTextBoxPassword.Text))
            {
                Form HomePage1 = new HomePage1();
                HomePage1.Show();
            }
            else
            {
                MessageBox.Show("You don't have an account");
                Form CreateAccount = new CreateAccount();
                CreateAccount.Show();
                   
            }

        }
        private void linkCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form CreateAccount = new CreateAccount();
            CreateAccount.Show();

            //CreateBooks create = new CreateBooks();
            //create.Show();

            //Form HomePage1 = new HomePage1();
            //HomePage1.Show();

            //BooksInEnglish booksInEnglish = new BooksInEnglish();
            //booksInEnglish.Show();

            Form UsersBooks = new UsersBooks();
            UsersBooks.Show();

            Payment payment = new Payment();
            payment.Show();
        }


    }

    // 
}
