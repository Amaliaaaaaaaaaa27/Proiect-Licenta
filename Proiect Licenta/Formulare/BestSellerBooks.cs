﻿using System;
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
    public partial class BestSellerBooks : Form
    {
        public BestSellerBooks()
        {
            InitializeComponent();
        }

        private void btnInfo_Bestseller_Click(object sender, EventArgs e)
        {
            Form InfoAccount = new InfoAccount();
            InfoAccount.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
