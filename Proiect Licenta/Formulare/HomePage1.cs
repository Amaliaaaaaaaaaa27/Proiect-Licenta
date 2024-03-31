using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_Licenta.Formulare
{
    public partial class HomePage1 : Form
    {
        public HomePage1()
        {
            InitializeComponent();
        }

        private void btn_Bestsellers_Click(object sender, EventArgs e)
        {

        }

        private void btn_EN_Click(object sender, EventArgs e)
        {
            Form BooksInEnglish = new BooksInEnglish();
            BooksInEnglish.Show();
        }

        private void btn_ROM_Click(object sender, EventArgs e)
        {
            Form BooksInRomanian = new BooksInRomanian();
            BooksInRomanian.Show();
        }

        private void btn_CreateBook_Click(object sender, EventArgs e)
        {
            Form CreateBooks = new CreateBooks();
            CreateBooks.Show();
        }

        private void btnInfo_hp_Click(object sender, EventArgs e)
        {
            Form InfoAccount = new InfoAccount();
            InfoAccount.Show();
        }
    }
}
