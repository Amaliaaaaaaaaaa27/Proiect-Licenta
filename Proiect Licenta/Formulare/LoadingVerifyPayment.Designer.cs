namespace Proiect_Licenta.Formulare
{
    partial class LoadingVerifyPayment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnClose_CheckPayment = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            lbl_CheckPayment = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            btnNext_CheckPayment = new Guna.UI2.WinForms.Guna2Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnClose_CheckPayment
            // 
            btnClose_CheckPayment.BackColor = Color.FromArgb(61, 140, 163);
            btnClose_CheckPayment.FlatStyle = FlatStyle.Flat;
            btnClose_CheckPayment.ForeColor = Color.White;
            btnClose_CheckPayment.Location = new Point(472, 30);
            btnClose_CheckPayment.Name = "btnClose_CheckPayment";
            btnClose_CheckPayment.Size = new Size(42, 36);
            btnClose_CheckPayment.TabIndex = 0;
            btnClose_CheckPayment.Text = "X";
            btnClose_CheckPayment.UseVisualStyleBackColor = false;
            btnClose_CheckPayment.Click += btnClose_CheckPayment_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(55, 186);
            panel1.Name = "panel1";
            panel1.Size = new Size(435, 44);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Green;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(59, 44);
            panel2.TabIndex = 0;
            // 
            // lbl_CheckPayment
            // 
            lbl_CheckPayment.AutoSize = true;
            lbl_CheckPayment.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_CheckPayment.ForeColor = Color.Green;
            lbl_CheckPayment.Location = new Point(66, 306);
            lbl_CheckPayment.Name = "lbl_CheckPayment";
            lbl_CheckPayment.Size = new Size(0, 28);
            lbl_CheckPayment.TabIndex = 2;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(55, 78);
            label2.Name = "label2";
            label2.Size = new Size(312, 43);
            label2.TabIndex = 3;
            label2.Text = "CHECK PAYMENT";
            // 
            // btnNext_CheckPayment
            // 
            btnNext_CheckPayment.BorderRadius = 10;
            btnNext_CheckPayment.CustomizableEdges = customizableEdges1;
            btnNext_CheckPayment.DisabledState.BorderColor = Color.DarkGray;
            btnNext_CheckPayment.DisabledState.CustomBorderColor = Color.DarkGray;
            btnNext_CheckPayment.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnNext_CheckPayment.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnNext_CheckPayment.FillColor = Color.FromArgb(105, 145, 110);
            btnNext_CheckPayment.Font = new Font("Segoe UI", 9F);
            btnNext_CheckPayment.ForeColor = Color.White;
            btnNext_CheckPayment.Location = new Point(329, 376);
            btnNext_CheckPayment.Name = "btnNext_CheckPayment";
            btnNext_CheckPayment.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnNext_CheckPayment.Size = new Size(204, 45);
            btnNext_CheckPayment.TabIndex = 4;
            btnNext_CheckPayment.Text = "NEXT";
            btnNext_CheckPayment.Click += btnNext_CheckPayment_Click;
            // 
            // LoadingVerifyPayment
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(545, 442);
            Controls.Add(btnNext_CheckPayment);
            Controls.Add(label2);
            Controls.Add(lbl_CheckPayment);
            Controls.Add(panel1);
            Controls.Add(btnClose_CheckPayment);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoadingVerifyPayment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoadingVerifyPayment";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose_CheckPayment;
        private Panel panel1;
        private Panel panel2;
        private Label lbl_CheckPayment;
        private System.Windows.Forms.Timer timer1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Button btnNext_CheckPayment;
    }
}