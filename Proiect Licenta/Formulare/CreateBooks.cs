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
    public partial class CreateBooks : Form
    {
        public CreateBooks()
        {
            InitializeComponent();

        }

        private void CreateBooks_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Create_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TextBox textBox1 = new TextBox();

                textBox1.BackColor = Color.White;
                textBox1.Width = 749;
                textBox1.Height = 74;
                textBox1.Location = new Point((sender as TextBox).Location.X + 275, (sender as TextBox).Location.Y + 260);
                textBox1.Font = new Font("SweetHeart", 35.999996f, FontStyle.Italic, GraphicsUnit.Point, 0);
                textBox1.KeyDown += textBox1_KeyDown;
                flowLayoutPanel1.Controls.Add(textBox1);
                textBox1.Focus();
                e.Handled = true;
            }
        }

        private void btnInfo_Create_Click(object sender, EventArgs e)
        {
            Form InfoAccount = new InfoAccount();
            InfoAccount.Show();
        }
    }


}
