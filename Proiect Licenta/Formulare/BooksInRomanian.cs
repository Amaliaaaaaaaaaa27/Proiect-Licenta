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
    public partial class BooksInRomanian : Form
    {
        public BooksInRomanian()
        {
            InitializeComponent();
        }
        private void BooksInRomanian_Load(object sender, EventArgs e)
        {

        }

        private void btnBooksPhilosophy_Rom_Click(object sender, EventArgs e)
        {
            PanelPsychology();
        }

        private void btnInfo_Rom_Click(object sender, EventArgs e)
        {
            Form InfoAccount = new InfoAccount();
            InfoAccount.Show();
        }

        public void PanelAction()
        {
            ClearGroupBox();
            Panel panelAc = new Panel();
            panelAc.Width = 799;
            panelAc.Height = 577;
            panelAc.BackColor = Color.FromArgb(148, 124, 176);
            groupBoxEn.Controls.Add(panelAc);

            Label labelAc = new Label();
            labelAc.Text = "Action";
            labelAc.Width = 400;
            labelAc.Height = 70;
            labelAc.BackColor = Color.FromArgb(148, 124, 176);
            labelAc.ForeColor = Color.Black;
            labelAc.Font = new Font("SweetHeart", 35.999996f, FontStyle.Italic, GraphicsUnit.Point, 0);
            panelAc.Controls.Add(labelAc);

            Button btnActionRo1 = new Button();
            btnActionRo1.Location = new Point(20,80);
            btnActionRo1.Width = 150;
            btnActionRo1.Height = 180;
            btnActionRo1.BackColor = Color.FromArgb(192, 192, 192);
            btnActionRo1.ForeColor = Color.Black;
            btnActionRo1.Text = "a";
            btnActionRo1.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelAc.Controls.Add(btnActionRo1);

            Button btnActionRo2 = new Button();
            btnActionRo2.Width = 150;
            btnActionRo2.Height = 180;
            btnActionRo2.Location = new Point(220,80);
            btnActionRo2.BackColor = Color.FromArgb(192, 192, 192);
            btnActionRo2.ForeColor = Color.Black;
            btnActionRo2.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnActionRo2.Text = "b";
            panelAc.Controls.Add(btnActionRo2);

            Button btnActionRo3 = new Button();
            btnActionRo3.Width = 150;
            btnActionRo3.Height = 180;
            btnActionRo3.Location = new Point(420,80);
            btnActionRo3.BackColor = Color.FromArgb(192, 192, 192);
            btnActionRo3.ForeColor = Color.Black;
            btnActionRo3.Text = "c";
            btnActionRo3.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelAc.Controls.Add(btnActionRo3);

            Button btnActionRo4 = new Button();
            btnActionRo4.Width = 150;
            btnActionRo4.Height = 180;
            btnActionRo4.Location = new Point(620,80);
            btnActionRo4.BackColor = Color.FromArgb(192, 192, 192);
            btnActionRo4.ForeColor = Color.Black;
            btnActionRo4.Text = "d";
            btnActionRo4.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelAc.Controls.Add(btnActionRo4);

            Button btnActionRo5 = new Button();
            btnActionRo5.Width = 150;
            btnActionRo5.Height = 180;
            btnActionRo5.Location = new Point(20, 350);
            btnActionRo5.BackColor = Color.FromArgb(192, 192, 192);
            btnActionRo5.ForeColor = Color.Black;
            btnActionRo5.Text = "e";
            btnActionRo5.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelAc.Controls.Add(btnActionRo5);

            Button btnActionRo6 = new Button();
            btnActionRo6.Width = 150;
            btnActionRo6.Height = 180;
            btnActionRo6.Location = new Point(220,350);
            btnActionRo6.BackColor = Color.FromArgb(192, 192, 192);
            btnActionRo6.ForeColor = Color.Black;
            btnActionRo6.Text = "f";
            btnActionRo6.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelAc.Controls.Add(btnActionRo6);

            Button btnActionRo7 = new Button();
            btnActionRo7.Width = 150;
            btnActionRo7.Height = 180;
            btnActionRo7.Location = new Point(420,350);
            btnActionRo7.BackColor = Color.FromArgb(192, 192, 192);
            btnActionRo7.ForeColor = Color.Black;
            btnActionRo7.Text = "g";
            btnActionRo7.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelAc.Controls.Add(btnActionRo7);

            Button btnActionRo8 = new Button();
            btnActionRo8.Width = 150;
            btnActionRo8.Height = 180;
            btnActionRo8.Location = new Point(620,350);
            btnActionRo8.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnActionRo8.Text = "h";
            btnActionRo8.BackColor = Color.FromArgb(192, 192, 192);
            btnActionRo8.ForeColor = Color.Black;
            panelAc.Controls.Add(btnActionRo8);

           
        }

        public void PanelSciences()
        {
            ClearGroupBox();
            Panel panelSc = new Panel();
            panelSc.Width = 799;
            panelSc.Height = 577;
            panelSc.BackColor = Color.FromArgb(148, 124, 176);
            groupBoxEn.Controls.Add(panelSc);

            Label labelSc = new Label();
            labelSc.Width = 400;
            labelSc.Height = 70;
            labelSc.BackColor = Color.FromArgb(148, 124, 176);
            labelSc.Text = "Sciences";
            labelSc.Font = new Font("SweetHeart", 35.999996f, FontStyle.Italic, GraphicsUnit.Point, 0);
            panelSc.Controls.Add(labelSc);

            Button btnSciencesRo1 = new Button();
            btnSciencesRo1.Width = 150;
            btnSciencesRo1.Height = 180;
            btnSciencesRo1.Location = new Point(20,80);
            btnSciencesRo1.BackColor = Color.FromArgb(192, 192, 192);
            btnSciencesRo1.ForeColor = Color.Black;
            btnSciencesRo1.Text = "a";
            btnSciencesRo1.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelSc.Controls.Add(btnSciencesRo1);

            Button btnSciencesRo2 = new Button();
            btnSciencesRo2.Width = 150;
            btnSciencesRo2.Height = 180;
            btnSciencesRo2.Location = new Point(220,80);
            btnSciencesRo2.BackColor = Color.FromArgb(192, 192, 192);
            btnSciencesRo2.ForeColor = Color.Black;
            btnSciencesRo2.Text = "b";
            btnSciencesRo2.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelSc.Controls.Add(btnSciencesRo2);

            Button btnSciencesRo3 = new Button();
            btnSciencesRo3.Width = 150;
            btnSciencesRo3.Height = 180;
            btnSciencesRo3.Location = new Point(420,80);
            btnSciencesRo3.BackColor = Color.FromArgb(192, 192, 192);
            btnSciencesRo3.ForeColor = Color.Black;
            btnSciencesRo3.Text = "c";
            btnSciencesRo3.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelSc.Controls.Add(btnSciencesRo3);

            Button btnSciencesRo4 = new Button();
            btnSciencesRo4.Width = 150;
            btnSciencesRo4.Height = 180;
            btnSciencesRo4.BackColor = Color.FromArgb(192, 192, 192);
            btnSciencesRo4.ForeColor = Color.Black;
            btnSciencesRo4.Text = "d";
            btnSciencesRo4.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSciencesRo4.Location = new Point(620,80);
            panelSc.Controls.Add(btnSciencesRo4);

            Button btnSciencesRo5 = new Button();
            btnSciencesRo5.Width = 150;
            btnSciencesRo5.Height = 180;
            btnSciencesRo5.BackColor = Color.FromArgb(192, 192, 192);
            btnSciencesRo5.ForeColor = Color.Black;
            btnSciencesRo5.Text = "e";
            btnSciencesRo5.Location = new Point(20,350);
            btnSciencesRo5.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelSc.Controls.Add(btnSciencesRo5);

            Button btnSciencesRo6 = new Button();
            btnSciencesRo6.Width = 150;
            btnSciencesRo6.Height = 180;
            btnSciencesRo6.BackColor = Color.FromArgb(192, 192, 192);
            btnSciencesRo6.ForeColor = Color.Black;
            btnSciencesRo6.Location = new Point(220,350);
            btnSciencesRo6.Text = "f";
            btnSciencesRo6.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelSc.Controls.Add(btnSciencesRo6);

            Button btnSciencesRo7 = new Button();
            btnSciencesRo7.Width = 150;
            btnSciencesRo7.Height = 180;
            btnSciencesRo7.BackColor = Color.FromArgb(192, 192, 192);
            btnSciencesRo7.ForeColor = Color.Black;
            btnSciencesRo7.Location = new Point(420,350);
            btnSciencesRo7.Text = "g";
            btnSciencesRo7.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelSc.Controls.Add(btnSciencesRo7);

            Button btnSciencesRo8 = new Button();
            btnSciencesRo8.Width = 150;
            btnSciencesRo8.Height = 180;
            btnSciencesRo8.BackColor = Color.FromArgb(192, 192, 192);
            btnSciencesRo8.ForeColor = Color.Black;
            btnSciencesRo8.Location = new Point(620,350);
            btnSciencesRo8.Text = "h";
            btnSciencesRo8.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelSc.Controls.Add(btnSciencesRo8);


        }

        public void PanelPsychology()
        {
            ClearGroupBox();
            Panel panelPsh = new Panel();
            panelPsh.Width = 799;
            panelPsh.Height = 577;
            panelPsh.BackColor = Color.FromArgb(148, 124, 176);
            groupBoxEn.Controls.Add(panelPsh);

            Label labelPsh = new Label();
            labelPsh.Width = 800;
            labelPsh.Height = 70;
            labelPsh.BackColor = Color.FromArgb(148, 124, 176);
            labelPsh.ForeColor = Color.Black;
            labelPsh.Text = "Philosophy/Psychology";
            labelPsh.Font = new Font("SweetHeart", 35.999996f, FontStyle.Italic, GraphicsUnit.Point, 0);
            panelPsh.Controls.Add(labelPsh);

            Button btnPsychologyRo1 = new Button();
            btnPsychologyRo1.Width = 150;
            btnPsychologyRo1.Height = 180;
            btnPsychologyRo1.Location = new Point(20,80);
            btnPsychologyRo1.BackColor = Color.FromArgb(192,192,192);
            btnPsychologyRo1.ForeColor = Color.Black;
            btnPsychologyRo1.Text = "a";
            btnPsychologyRo1.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelPsh.Controls.Add(btnPsychologyRo1);

            Button btnPsychologyRo2 = new Button();
            btnPsychologyRo2.Width = 150;
            btnPsychologyRo2.Height = 180;
            btnPsychologyRo2.Location = new Point(220,80);
            btnPsychologyRo2.BackColor = Color.FromArgb(192, 192, 192);
            btnPsychologyRo2.ForeColor = Color.Black;
            btnPsychologyRo2.Text = "b";
            btnPsychologyRo2.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelPsh.Controls.Add(btnPsychologyRo2);

            Button btnPsychologyRo3 = new Button();
            btnPsychologyRo3.Width = 150;
            btnPsychologyRo3.Height = 180;
            btnPsychologyRo3.Location = new Point(420,80);
            btnPsychologyRo3.BackColor = Color.FromArgb(192, 192, 192);
            btnPsychologyRo3.ForeColor = Color.Black;
            btnPsychologyRo3.Text = "c";
            btnPsychologyRo3.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelPsh.Controls.Add(btnPsychologyRo3);

            Button btnPsychologyRo4 = new Button();
            btnPsychologyRo4.Width = 150;
            btnPsychologyRo4.Height = 180;
            btnPsychologyRo4.Location = new Point(620,80);
            btnPsychologyRo4.BackColor = Color.FromArgb(192,192,192);
            btnPsychologyRo4.ForeColor = Color.Black;
            btnPsychologyRo4.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPsychologyRo4.Text = "d";
            panelPsh.Controls.Add(btnPsychologyRo4);

            Button btnPsychologyRo5 = new Button();
            btnPsychologyRo5.Width = 150;
            btnPsychologyRo5.Height = 180;
            btnPsychologyRo5.Location = new Point(20,350);
            btnPsychologyRo5.BackColor = Color.FromArgb(192,192,192);
            btnPsychologyRo5.ForeColor = Color.Black;
            btnPsychologyRo5.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPsychologyRo5.Text = "e";
            panelPsh.Controls.Add(btnPsychologyRo5);

            Button btnPsychologyRo6 = new Button();
            btnPsychologyRo6.Width = 150;
            btnPsychologyRo6.Height = 180;
            btnPsychologyRo6.Location = new Point(220,350);
            btnPsychologyRo6.BackColor = Color.FromArgb(192, 192, 192);
            btnPsychologyRo6.ForeColor = Color.Black;
            btnPsychologyRo6.Text = "f";
            btnPsychologyRo6.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelPsh.Controls.Add(btnPsychologyRo6);

            Button btnPsychologyRo7 = new Button();
            btnPsychologyRo7.Width = 150;
            btnPsychologyRo7.Height = 180;
            btnPsychologyRo7.Location = new Point(420,350);
            btnPsychologyRo7.BackColor = Color.FromArgb(192,192,192);
            btnPsychologyRo7.ForeColor = Color.Black;
            btnPsychologyRo7.Text = "g";
            btnPsychologyRo7.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelPsh.Controls.Add(btnPsychologyRo7);

            Button btnPsychologyRo8 =new Button();
            btnPsychologyRo8.Width = 150;
            btnPsychologyRo8.Height = 180;
            btnPsychologyRo8.Location = new Point(620,350);
            btnPsychologyRo8.ForeColor = Color.Black;
            btnPsychologyRo8.BackColor = Color.FromArgb(192,192,192);
            btnPsychologyRo8.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPsychologyRo8.Text = "h";
            panelPsh.Controls.Add(btnPsychologyRo8);
        }
        public void ClearGroupBox()
        {
            groupBoxEn.Controls.Clear();
        }

        private void btnExitBooksRo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBooksAction_Rom_Click(object sender, EventArgs e)
        {
            PanelAction();
        }

        private void btnBookSciences_Rom_Click(object sender, EventArgs e)
        {
            PanelSciences();
        }
    }
}
