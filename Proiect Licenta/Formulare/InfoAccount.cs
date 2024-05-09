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
    public partial class InfoAccount : Form
    {
        public InfoAccount()
        {
            InitializeComponent();
        }

        private void InfoAccount_Load(object sender, EventArgs e)
        {

        }
        
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public User user { get; set; }

        public ManagmentDataBase dataBase;

        public void ShowName()
        {

            //lblName.Text = dataBase.ExtractName();
        }
        public void ShowGmail()
        {
            lblName.Text = dataBase.ExtractGmail();
        }
        public void ShowAge()
        {
            int a = dataBase.FindAge();
            lblAge.Text = a.ToString();
        }
        public void ShowSubscription()
        {

        }

       
    }
}


//public void AddInfo()
//{
//    int finalAge = FindAge();
//    user.ExtractDataFromCnp(user.CNP.ToString());
//    lblName.Text = $"{user.Name}";
//    lblGmail.Text = $"{user.Gmail}";
//    lblAge.Text = $"{finalAge}";
//    lblSubs.Text = $"";

//}