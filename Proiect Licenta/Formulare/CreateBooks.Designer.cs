namespace Proiect_Licenta.Formulare
{
    partial class CreateBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateBooks));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            btnExit_Create = new Guna.UI2.WinForms.Guna2Button();
            btnInfo_Create = new Button();
            lblUserHii_CreateBooks = new Label();
            guna2vScrollBar1 = new Guna.UI2.WinForms.Guna2VScrollBar();
            flowLayoutPanel1 = new FlowLayoutPanel();
            textBox1 = new TextBox();
            label2 = new Label();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(476, 31);
            label1.Name = "label1";
            label1.Size = new Size(343, 43);
            label1.TabIndex = 0;
            label1.Text = "Create your books";
            // 
            // btnExit_Create
            // 
            btnExit_Create.CustomizableEdges = customizableEdges1;
            btnExit_Create.DisabledState.BorderColor = Color.DarkGray;
            btnExit_Create.DisabledState.CustomBorderColor = Color.DarkGray;
            btnExit_Create.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnExit_Create.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnExit_Create.FillColor = Color.FromArgb(61, 140, 163);
            btnExit_Create.Font = new Font("Segoe UI", 9F);
            btnExit_Create.ForeColor = Color.White;
            btnExit_Create.Location = new Point(1124, 38);
            btnExit_Create.Name = "btnExit_Create";
            btnExit_Create.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnExit_Create.Size = new Size(42, 36);
            btnExit_Create.TabIndex = 3;
            btnExit_Create.Text = "X";
            btnExit_Create.Click += btnExit_Create_Click;
            // 
            // btnInfo_Create
            // 
            btnInfo_Create.BackgroundImage = (Image)resources.GetObject("btnInfo_Create.BackgroundImage");
            btnInfo_Create.FlatStyle = FlatStyle.Flat;
            btnInfo_Create.Location = new Point(27, 73);
            btnInfo_Create.Name = "btnInfo_Create";
            btnInfo_Create.Size = new Size(71, 70);
            btnInfo_Create.TabIndex = 4;
            btnInfo_Create.UseVisualStyleBackColor = true;
            btnInfo_Create.Click += btnInfo_Create_Click;
            // 
            // lblUserHii_CreateBooks
            // 
            lblUserHii_CreateBooks.AutoSize = true;
            lblUserHii_CreateBooks.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserHii_CreateBooks.Location = new Point(104, 113);
            lblUserHii_CreateBooks.Name = "lblUserHii_CreateBooks";
            lblUserHii_CreateBooks.Size = new Size(282, 30);
            lblUserHii_CreateBooks.TabIndex = 5;
            lblUserHii_CreateBooks.Text = "Hii.., good luck writing!";
            // 
            // guna2vScrollBar1
            // 
            guna2vScrollBar1.AccessibleRole = AccessibleRole.ScrollBar;
            guna2vScrollBar1.AllowDrop = true;
            guna2vScrollBar1.AutoScroll = true;
            guna2vScrollBar1.BorderRadius = 10;
            guna2vScrollBar1.InUpdate = false;
            guna2vScrollBar1.LargeChange = 10;
            guna2vScrollBar1.Location = new Point(877, 252);
            guna2vScrollBar1.Name = "guna2vScrollBar1";
            guna2vScrollBar1.ScrollbarSize = 27;
            guna2vScrollBar1.Size = new Size(27, 666);
            guna2vScrollBar1.TabIndex = 7;
            guna2vScrollBar1.Scroll += guna2vScrollBar1_Scroll;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackgroundImage = (Image)resources.GetObject("flowLayoutPanel1.BackgroundImage");
            flowLayoutPanel1.Controls.Add(textBox1);
            flowLayoutPanel1.Location = new Point(119, 252);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(752, 666);
            flowLayoutPanel1.TabIndex = 8;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("SweetHeart", 35.9999962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(3, 3);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(749, 74);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("manic-depressive", 15.999999F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(119, 183);
            label2.Name = "label2";
            label2.Size = new Size(533, 66);
            label2.TabIndex = 1;
            label2.Text = "Press enter to go to the next line";
            // 
            // guna2Button1
            // 
            guna2Button1.BackColor = Color.WhiteSmoke;
            guna2Button1.BackgroundImageLayout = ImageLayout.Center;
            guna2Button1.BorderRadius = 10;
            guna2Button1.CustomizableEdges = customizableEdges3;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(105, 145, 110);
            guna2Button1.Font = new Font("manic-depressive", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(1015, 252);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button1.Size = new Size(73, 245);
            guna2Button1.TabIndex = 9;
            guna2Button1.Text = "S  a  v  e                                                                          avr";
            // 
            // guna2Button2
            // 
            guna2Button2.BorderRadius = 10;
            guna2Button2.CustomizableEdges = customizableEdges5;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.FromArgb(105, 145, 110);
            guna2Button2.Font = new Font("manic-depressive", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2Button2.ForeColor = Color.White;
            guna2Button2.Location = new Point(1015, 539);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Button2.Size = new Size(73, 307);
            guna2Button2.TabIndex = 10;
            guna2Button2.Text = "C l e a n";
            // 
            // CreateBooks
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(228, 241, 254);
            ClientSize = new Size(1220, 955);
            Controls.Add(guna2Button2);
            Controls.Add(guna2Button1);
            Controls.Add(label2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(guna2vScrollBar1);
            Controls.Add(lblUserHii_CreateBooks);
            Controls.Add(btnInfo_Create);
            Controls.Add(btnExit_Create);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CreateBooks";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            Load += CreateBooks_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Guna.UI2.WinForms.Guna2Button btnExit_Create;
        private Button btnInfo_Create;
        private Label lblUserHii_CreateBooks;
        private GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2VScrollBar guna2vScrollBar1;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox textBox1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}