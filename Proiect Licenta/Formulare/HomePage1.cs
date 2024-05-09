using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Proiect_Licenta.Formulare
{
    public partial class HomePage1 : Form
    {
        public HomePage1()
        {
            InitializeComponent();
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



        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();

            DataColumn ID = new DataColumn();
            ID.DataType = typeof(int);
            ID.Unique = true;
            // true dacă sunt permise valori null in cazul nostru nu acceptam valori nule
            ID.AllowDBNull = false;
            ID.ColumnName = "BookID";
            table.Columns.Add(ID);


            DataColumn nameBook = new DataColumn();
            nameBook.DataType = typeof(string);
            nameBook.AllowDBNull = false;
            nameBook.ColumnName = "Name book";
            table.Columns.Add(nameBook);

            DataColumn nameAuthor = new DataColumn();
            nameAuthor.DataType = typeof(string);
            nameAuthor.AllowDBNull = true;
            nameAuthor.ColumnName = "Author book";
            table.Columns.Add(nameAuthor);


            ManagmentDataBase dataBase = new ManagmentDataBase();
            dataBase.Search(txtBoxSearch.Text,table);
            DataGridView1.DataSource = table;


        }
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
