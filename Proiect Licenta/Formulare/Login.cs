using Proiect_Licenta.Formulare;

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

        private void btnLogin_Click(object sender, EventArgs e)
        {
           
        }

        private void linkCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Form CreateAccount = new CreateAccount();
            //CreateAccount.Show();

            Form CreateBooks = new CreateBooks();
            CreateBooks.Show();
        }
    }
}
