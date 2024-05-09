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

    public partial class Subscription : Form
    {
        ManagmentDataBase managment = new ManagmentDataBase();
        public Subscription()
        {
            InitializeComponent();
        }
        private void btnClose_Subscription_Click(object sender, EventArgs e)
         {
            this.Close();
        }

        private void btnBasic_Subscription_Click(object sender, EventArgs e)
        {
            managment.CreateTableSubsBasic();
            managment.SubscBasic();
            managment.UserTableAndTableSubsB();
            Form Payment = new Payment();
            Payment.Show();
        }

        private void btnPremium_Subscription_Click(object sender, EventArgs e)
        {
            managment.CreateTableSubsPremium();
            managment.SubsPremium();
            managment.UserTableAndTableSubsP();

            Form Payment = new Payment();
            Payment.Show();
        }

        private void btnAnnual_Subscription_Click(object sender, EventArgs e)
        {
            managment.CreateTableSubsAnnualy();
            managment.SubsAnnualy();
            managment.UserTableAndTableSubsA();

            Form Payment = new Payment();
            Payment.Show();
        }

        private void btnBack_Subscription_Click(object sender, EventArgs e)
        {
            Form CreateAccount = new CreateAccount();
            CreateAccount.Show();
        }

        private void Subscription_Load(object sender, EventArgs e)
        {
            managment.SelectTableSubscription();
            managment.InsertIntoTableSubscription();
        }

       
    }
}
