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
    public partial class LoadingVerifyPayment : Form
    {
        public LoadingVerifyPayment()
        {
            InitializeComponent();

            Timer();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Timer();
        }

        public void Timer()
        {
            panel2.Width += 3;

            if (panel2.Width >= 488)
            {
                timer1.Stop();

                LabelCkeckPayment();

                Form HomePage1 = new HomePage1();
                HomePage1.Show();
            }
        }

        public void LabelCkeckPayment()
        {
            lbl_CheckPayment.Text = "CONFIRMARE PLATA";
        }
        private void btnClose_CheckPayment_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext_CheckPayment_Click(object sender, EventArgs e)
        {
            Timer();
        }
    }
}
