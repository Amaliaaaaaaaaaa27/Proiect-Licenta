namespace Proiect_Licenta.Formulare
{
    partial class InfoAccount
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btn_Exit = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // btn_Exit
            // 
            btn_Exit.CustomizableEdges = customizableEdges1;
            btn_Exit.DisabledState.BorderColor = Color.DarkGray;
            btn_Exit.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_Exit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_Exit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_Exit.FillColor = Color.FromArgb(61, 140, 163);
            btn_Exit.Font = new Font("Segoe UI", 9F);
            btn_Exit.ForeColor = Color.White;
            btn_Exit.Location = new Point(364, 23);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btn_Exit.Size = new Size(42, 36);
            btn_Exit.TabIndex = 4;
            btn_Exit.Text = "X";
            btn_Exit.Click += btn_Exit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 107);
            label1.Name = "label1";
            label1.Size = new Size(394, 43);
            label1.TabIndex = 5;
            label1.Text = " About your account ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F);
            label2.Location = new Point(36, 251);
            label2.Name = "label2";
            label2.Size = new Size(94, 30);
            label2.TabIndex = 6;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F);
            label3.Location = new Point(37, 339);
            label3.Name = "label3";
            label3.Size = new Size(93, 30);
            label3.TabIndex = 7;
            label3.Text = "Gmail:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F);
            label4.Location = new Point(37, 422);
            label4.Name = "label4";
            label4.Size = new Size(69, 30);
            label4.TabIndex = 8;
            label4.Text = "Age:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F);
            label5.Location = new Point(37, 511);
            label5.Name = "label5";
            label5.Size = new Size(223, 30);
            label5.TabIndex = 9;
            label5.Text = "Subscription type:";
            // 
            // InfoAccount
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(139, 191, 164);
            ClientSize = new Size(426, 675);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_Exit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InfoAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InfoAccount";
            Load += InfoAccount_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_Exit;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}