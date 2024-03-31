using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_Licenta.Formulare
{
    public partial class BooksInEnglish : Form
    {
        public BooksInEnglish()
        {
            InitializeComponent();
        }


        private void BtnExitBooksEn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BooksInEnglish_Load(object sender, EventArgs e)
        {

        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnIngo_En_Click(object sender, EventArgs e)
        {
            Form InfoAccount = new InfoAccount();
            InfoAccount.Show();
        }
    }
}
