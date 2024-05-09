using System; 
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp;
using System.Text.Encodings;
using System.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Fonts;
using PdfSharp.Drawing;
using PdfSharp.UniversalAccessibility.Drawing;
using PdfSharp.Quality;

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


        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            label3.Text = currentTime.ToString("hh:mm tt");
            label3.Font = new Font("SweetHeart", 35.999996f, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Show();
        }

        private void btnInfo_Create_Click(object sender, EventArgs e)
        {
            Form InfoAccount = new InfoAccount();
            InfoAccount.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        List<TextBox> txtBoxList = new List<TextBox>();

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TextBox textBox = new TextBox();
                textBox.BackColor = Color.White;
                textBox.Width = 787;
                textBox.Height = 71;
                textBox.Font = new Font("SweetHeart", 35.999996f, FontStyle.Italic, GraphicsUnit.Point, 0);
                txtBoxList.Add(textBox);
                textBox.Location = new Point((sender as TextBox).Location.X + 275, (sender as TextBox).Location.Y + 260);
                textBox.KeyDown += textBox2_KeyDown;
                flowLayoutPanel1.Controls.Add(textBox);
                textBox.Focus();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnClean_Click(object sender, EventArgs e)
        {
           
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            int coordY = 20;
            using (SaveFileDialog sfg = new SaveFileDialog())
            {
                if(sfg.ShowDialog() == DialogResult.OK)
                {
                    GlobalFontSettings.FontResolver = new FileSystemFontResolver();

                    PdfDocument doc = new PdfDocument();

                    PdfPage page = doc.AddPage();

                    XGraphics gfx = XGraphics.FromPdfPage(page);

                    for(int i = 0; i < txtBoxList.Count; i++)
                    {
                        gfx.DrawString(txtBoxList[i].Text, new XFont("Arial",20), XBrushes.Black, new XPoint(10,coordY));

                        coordY += 20;
                    }

                    doc.Save(sfg.FileName);
                }
            }
        }
    }




}


