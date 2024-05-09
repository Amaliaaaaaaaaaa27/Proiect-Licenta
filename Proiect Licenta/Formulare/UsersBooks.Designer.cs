namespace Proiect_Licenta.Formulare
{
    partial class UsersBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersBooks));
            btnInfo = new Button();
            btnClose_Subscription = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnInfo
            // 
            btnInfo.BackgroundImage = (Image)resources.GetObject("btnInfo.BackgroundImage");
            btnInfo.FlatStyle = FlatStyle.Flat;
            btnInfo.ForeColor = Color.FromArgb(228, 241, 254);
            btnInfo.Location = new Point(38, 33);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(71, 70);
            btnInfo.TabIndex = 5;
            btnInfo.UseVisualStyleBackColor = true;
            // 
            // btnClose_Subscription
            // 
            btnClose_Subscription.BackColor = Color.FromArgb(61, 140, 163);
            btnClose_Subscription.FlatStyle = FlatStyle.Flat;
            btnClose_Subscription.Location = new Point(1073, 50);
            btnClose_Subscription.Name = "btnClose_Subscription";
            btnClose_Subscription.Size = new Size(42, 36);
            btnClose_Subscription.TabIndex = 6;
            btnClose_Subscription.Text = "X";
            btnClose_Subscription.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(115, 78);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 7;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(358, 78);
            label2.Name = "label2";
            label2.Size = new Size(466, 49);
            label2.TabIndex = 8;
            label2.Text = "Books created by users";
            // 
            // UsersBooks
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(228, 241, 254);
            ClientSize = new Size(1170, 610);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnClose_Subscription);
            Controls.Add(btnInfo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UsersBooks";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInfo;
        private Button btnClose_Subscription;
        private Label label1;
        private Label label2;
    }
}