using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfiumViewer;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proiect_Licenta.Formulare
{
    public partial class BooksInEnglish : Form
    {
        public BooksInEnglish()
        {
            InitializeComponent();
        }
        private void btnBookAction_En_Click(object sender, EventArgs e)
        {
            PanelAction();
        }
        private void btnBookSciences_En_Click(object sender, EventArgs e)
        {
            PanelSciences();
        }

        private void btnBookPhilosophy_En_Click(object sender, EventArgs e)
        {
            PanelPhilosophy();

        }
        private void BtnExitBooksEn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnIngo_En_Click(object sender, EventArgs e)
        {
            Form InfoAccount = new InfoAccount();
            InfoAccount.Show();
        }
        public void PanelPhilosophy()
        {
            DeletePreviosPanel();
            Panel panel = new Panel();
            panel.Width = 799;
            panel.Height = 577;
            panel.BackColor = Color.FromArgb(107, 15, 2);
            groupBox2.Controls.Add(panel);

            Label label = new Label();
            label.Width = 400;
            label.Height = 70;
            label.ForeColor = Color.Black;
            label.Text = "Philosophy/Psychology";
            label.Font = new Font("SweetHeart", 35.999996f, FontStyle.Italic, GraphicsUnit.Point, 0);
            label.Show();

            panel.Controls.Add(label);

            System.Windows.Forms.Button buttonPsychology1 = new System.Windows.Forms.Button();
            buttonPsychology1.Width = 150;
            buttonPsychology1.Height = 180;
            buttonPsychology1.Location = new Point(20, 80);
            buttonPsychology1.BackColor = Color.FromArgb(59, 141, 170);
            buttonPsychology1.ForeColor = Color.Black;
            buttonPsychology1.Text = "Thought and Language \n  by  Lev Vygotsky ";
            buttonPsychology1.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel.Controls.Add(buttonPsychology1);
            buttonPsychology1.Click += Button_Click;




            System.Windows.Forms.Button buttonPsychology2 = new System.Windows.Forms.Button();
            buttonPsychology2.Width = 150;
            buttonPsychology2.Height = 180;
            buttonPsychology2.Location = new Point(220, 80);
            buttonPsychology2.BackColor = Color.FromArgb(59, 141, 170);
            buttonPsychology2.ForeColor = Color.Black;
            buttonPsychology2.Text = "The Art of Loving \n by  Erich Fromm";
            buttonPsychology2.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel.Controls.Add(buttonPsychology2);
            buttonPsychology2.Click += Button_Click;



            System.Windows.Forms.Button buttonPsychology3 = new System.Windows.Forms.Button();
            buttonPsychology3.Width = 150;
            buttonPsychology3.Height = 180;
            buttonPsychology3.Location = new Point(420, 80);
            buttonPsychology3.BackColor = Color.FromArgb(59, 141, 170);
            buttonPsychology3.ForeColor = Color.Black;
            buttonPsychology3.Text = "The Ego and the Mechanisms of Defence\n by Anna Freud";
            buttonPsychology3.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel.Controls.Add(buttonPsychology3);
            buttonPsychology3.Click += Button_Click;

            System.Windows.Forms.Button buttonPsychology4 = new System.Windows.Forms.Button();
            buttonPsychology4.Width = 150;
            buttonPsychology4.Height = 180;
            buttonPsychology4.Location = new Point(620, 80);
            buttonPsychology4.BackColor = Color.FromArgb(59, 141, 170);
            buttonPsychology4.ForeColor = Color.Black;
            buttonPsychology4.Text = "Self Analysis\n Horney, Karen";
            buttonPsychology4.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel.Controls.Add(buttonPsychology4);
            buttonPsychology4.Click += Button_Click;

            System.Windows.Forms.Button buttonPsychology5 = new System.Windows.Forms.Button();
            buttonPsychology5.Width = 150;
            buttonPsychology5.Height = 180;
            buttonPsychology5.Location = new Point(20, 350);
            buttonPsychology5.BackColor = Color.FromArgb(59, 141, 170);
            buttonPsychology5.ForeColor = Color.Black;
            buttonPsychology5.Text = "The Psychology Of The Child \n by Jean Piaget";
            buttonPsychology5.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel.Controls.Add(buttonPsychology5);
            buttonPsychology5.Click += Button_Click;


            System.Windows.Forms.Button buttonPsychology6 = new System.Windows.Forms.Button();
            buttonPsychology6.Width = 150;
            buttonPsychology6.Height = 180;
            buttonPsychology6.Location = new Point(220, 350);
            buttonPsychology6.BackColor = Color.FromArgb(59, 141, 170);
            buttonPsychology6.ForeColor = Color.Black;
            buttonPsychology6.Text = "Childhood And Society \n by Erik Erikson";
            buttonPsychology6.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel.Controls.Add(buttonPsychology6);
            buttonPsychology6.Click += Button_Click;


            System.Windows.Forms.Button buttonPsychology7 = new System.Windows.Forms.Button();
            buttonPsychology7.Width = 150;
            buttonPsychology7.Height = 180;
            buttonPsychology7.Location = new Point(420, 350);
            buttonPsychology7.BackColor = Color.FromArgb(59, 141, 170);
            buttonPsychology7.ForeColor = Color.Black;
            buttonPsychology7.Text = "A General Introduction to Psychoanalysis,\n by Sigmund Freud ";
            buttonPsychology7.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel.Controls.Add(buttonPsychology7);
            buttonPsychology7.Click += Button_Click;

            System.Windows.Forms.Button buttonPsychology8 = new System.Windows.Forms.Button();
            buttonPsychology8.Width = 150;
            buttonPsychology8.Height = 180;
            buttonPsychology8.Location = new Point(620, 350);
            buttonPsychology8.BackColor = Color.FromArgb(59, 141, 170);
            buttonPsychology8.Text = "Introduction to Psychology";
            buttonPsychology8.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel.Controls.Add(buttonPsychology8);
            buttonPsychology8.Click += Button_Click;

        }

        private void Button_DoubleClick(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void PanelSciences()
        {
            DeletePreviosPanel();
            Panel panel = new Panel();
            panel.Width = 799;
            panel.Height = 577;
            panel.BackColor = Color.FromArgb(107, 15, 2);
            groupBox2.Controls.Add(panel);

            Label label = new Label();
            label.Width = 200;
            label.Height = 70;
            label.ForeColor = Color.Black;
            label.Text = "Sciences";
            label.Font = new Font("SweetHeart", 35.999996f, FontStyle.Italic, GraphicsUnit.Point, 0);
            label.Show();
            // punem labelul peste panel, daca punem peste groupbox nu se vedea 
            panel.Controls.Add(label);

            // aveam eroare cu abiguitatea asadar specificând spațiul de nume complet pentru a creea un buton 
            System.Windows.Forms.Button button1 = new System.Windows.Forms.Button();
            button1.BackColor = Color.FromArgb(59, 141, 170);
            button1.ForeColor = Color.Black;
            button1.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Text = "A Brief History of Time \n by Stephen Hawking";
            button1.Width = 150;
            button1.Height = 180;
            button1.Location = new Point(20, 80);
            panel.Controls.Add(button1);// adaugam buttonul 1 peste panel
            button1.Click += Button_Click;

            System.Windows.Forms.Button button2 = new System.Windows.Forms.Button();
            button2.Width = 150;
            button2.Height = 180;
            button2.Location = new Point(220, 80); // 220+80 = 400
            button2.BackColor = Color.FromArgb(59, 141, 170);
            button2.ForeColor = Color.Black;
            button2.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Text = "Fundamentals of \n Computer Programming \n with C#";
            //adaugam buttonul 2 peste panel 
            panel.Controls.Add(button2);
            button2.Click += Button_Click;

            System.Windows.Forms.Button button3 = new System.Windows.Forms.Button();
            button3.Width = 150;
            button3.Height = 180;
            button3.Location = new Point(420, 80);
            button3.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Text = "Theory of Everything \n  by Fran De Aquino";
            button3.BackColor = Color.FromArgb(59, 141, 170);
            button3.ForeColor = Color.Black;
            panel.Controls.Add(button3);
            button3.Click += Button_Click;

            System.Windows.Forms.Button button4 = new System.Windows.Forms.Button();
            button4.Width = 150;
            button4.Height = 180;
            button4.Location = new Point(620, 80);
            button4.BackColor = Color.FromArgb(59, 141, 170);
            button4.ForeColor = Color.Black;
            button4.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Text = "SQL for Dummies \n by Allen G. Taylor";
            panel.Controls.Add(button4);
            button4.Click += Button_Click;

            System.Windows.Forms.Button button5 = new System.Windows.Forms.Button();
            button5.Width = 150;
            button5.Height = 180;
            button5.Location = new Point(20, 350);
            button5.BackColor = Color.FromArgb(59, 141, 170);
            button5.ForeColor = Color.Black;
            button5.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Text = "The Maths E-book of Notes \n  by Mr Barton Maths";
            panel.Controls.Add(button5);
            button5.Click += Button_Click;

            System.Windows.Forms.Button button6 = new System.Windows.Forms.Button();
            button6.Width = 150;
            button6.Height = 180;
            button6.Location = new Point(220, 350);
            button6.BackColor = Color.FromArgb(59, 141, 170);
            button6.ForeColor = Color.Black;
            button6.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.Text = "ARDUINO for BEGINNERS \n  by John Baichal";
            panel.Controls.Add(button6);
            button6.Click += Button_Click;

            System.Windows.Forms.Button button7 = new System.Windows.Forms.Button();
            button7.Width = 150;
            button7.Height = 180;
            button7.Location = new Point(420, 350);
            button7.BackColor = Color.FromArgb(59, 141, 170);
            button7.ForeColor = Color.Black;
            button7.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.Text = "Introduction to logic programming \n  by Ronald J. Brachman";
            panel.Controls.Add(button7);
            button7.Click += Button_Click;

            System.Windows.Forms.Button button8 = new System.Windows.Forms.Button();
            button8.Width = 150;
            button8.Height = 180;
            button8.Location = new Point(620, 350);
            button8.BackColor = Color.FromArgb(59, 141, 170);
            button8.ForeColor = Color.Black;
            button8.Text = "Learning C# by Developing Games with Unity 3D .. \n by Terry Norton ";
            button8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel.Controls.Add(button8);
            button8.Click += Button_Click;

        }

        public void PanelAction()
        {
            DeletePreviosPanel();
            Panel panel = new Panel();
            panel.Width = 799;
            panel.Height = 577;
            //panel.Location = new Point(498, 174);
            panel.BackColor = Color.FromArgb(107, 15, 2);
            groupBox2.Controls.Add(panel);
            // intai am creat panelul 

            // am creat un label care se va afisa pe label
            Label label = new Label();
            label.Width = 200;
            label.Height = 70;
            label.Text = "Action";
            label.Font = new Font("SweetHeart", 35.999996f, FontStyle.Italic, GraphicsUnit.Point, 0);
            label.ForeColor = Color.Black;

            panel.Controls.Add(label);

            System.Windows.Forms.Button button1Action = new System.Windows.Forms.Button();
            button1Action.Width = 150;
            button1Action.Height = 180;
            button1Action.Text = " Our Reluctant Man in Berlin \n by Ken Donald"; //din baza de date sa se extrage nu le scriu eu 
            button1Action.ForeColor = Color.Black;
            button1Action.BackColor = Color.FromArgb(59, 141, 170);
            button1Action.Location = new Point(20, 80);
            button1Action.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel.Controls.Add(button1Action);
            button1Action.Click += Button_Click;

            System.Windows.Forms.Button button2Action = new System.Windows.Forms.Button();
            button2Action.Width = 150;
            button2Action.Height = 180;
            button2Action.Text = "The hunger games \n by Suzanne Collins";
            button2Action.Location = new Point(220, 80);
            button2Action.ForeColor = Color.Black;
            button2Action.BackColor = Color.FromArgb(59, 141, 170);
            button2Action.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel.Controls.Add(button2Action);
            button2Action.Click += Button_Click;

            System.Windows.Forms.Button button3Action = new System.Windows.Forms.Button();
            button3Action.Width = 150;
            button3Action.Height = 180;
            button3Action.Text = "ENDER'S GAME\r\n by Orson Scott Card ";
            button3Action.Location = new Point(420, 80);
            button3Action.ForeColor = Color.Black;
            button3Action.BackColor = Color.FromArgb(59, 141, 170);
            button3Action.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel.Controls.Add(button3Action);
            button3Action.Click += Button_Click;



            System.Windows.Forms.Button button4Action = new System.Windows.Forms.Button();
            button4Action.Width = 150;
            button4Action.Height = 180;
            button4Action.Text = "The Bourne Identity \n by Robert Ludlum";
            button4Action.Location = new Point(620, 80);
            button4Action.ForeColor = Color.Black;
            button4Action.BackColor = Color.FromArgb(59, 141, 170);
            button4Action.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel.Controls.Add(button4Action);
            button4Action.Click += Button_Click;


            System.Windows.Forms.Button button5Action = new System.Windows.Forms.Button();
            button5Action.Width = 150;
            button5Action.Height = 180;
            button5Action.Text = "The Battle of the Labyrinth \n by Rick Riordan ";
            button5Action.Location = new Point(20, 350);
            button5Action.ForeColor = Color.Black;
            button5Action.BackColor = Color.FromArgb(59, 141, 170);
            button5Action.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel.Controls.Add(button5Action);
            button5Action.Click += Button_Click;

            System.Windows.Forms.Button button6Action = new System.Windows.Forms.Button();
            button6Action.Width = 150;
            button6Action.Height = 180;
            button6Action.Text = "Jurassic Park\n by Michael Crichton";
            button6Action.Location = new Point(220, 350);
            button6Action.BackColor = Color.FromArgb(59, 141, 170);
            button6Action.ForeColor = Color.Black;
            button6Action.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel.Controls.Add(button6Action);
            button6Action.Click += Button_Click;


            System.Windows.Forms.Button button7Action = new System.Windows.Forms.Button();
            button7Action.Width = 150;
            button7Action.Height = 180;
            button7Action.Location = new Point(420, 350);
            button7Action.BackColor = Color.FromArgb(59, 141, 170);
            button7Action.ForeColor = Color.Black;
            button7Action.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7Action.Text = "Oliver Twist \n by Charles Dickens";
            panel.Controls.Add(button7Action);
            button7Action.Click += Button_Click;


            System.Windows.Forms.Button button8Action = new System.Windows.Forms.Button();
            button8Action.Width = 150;
            button8Action.Height = 180;
            button8Action.Location = new Point(620, 350);
            button8Action.BackColor = Color.FromArgb(59, 141, 170);
            button8Action.ForeColor = Color.Black;
            button8Action.Text = "Allegiant \n by Veronica Roth";
            button8Action.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel.Controls.Add(button8Action);
            button8Action.Click += Button_Click;
            // in panel am adaugat labelul
        }

        public void DeletePreviosPanel()
        {
            // Curatam ce s a pus in groupbox2 deoarece urmatorul panou nu ar fi vizibil 
            groupBox2.Controls.Clear();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void BooksInEnglish_Load(object sender, EventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        int counter = 0;

        // folosim lastButton pt a tine referinta ultimului buton care a fost apasat 

        private System.Windows.Forms.Button lastbutton = null;
        public void Button_Click(object sender, EventArgs e)
        {   // stocam referinta butonului care a fost declansat in button, practic celui ce i am dat click
            var button = sender as System.Windows.Forms.Button;
            if (button.Focus())
            {
                counter++;
                MessageBox.Show($"You have {counter} books ");
                lblCounter.Text = $" Counter book: {counter}";

                lastbutton = button;

            }

        }

        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            counter--;
            MessageBox.Show($"You have {counter} books\n You deleted the {lastbutton.Text} ");
            lblCounter.Text = $"Counter book: {counter}";

            lastbutton = null;
        }
    }
}

