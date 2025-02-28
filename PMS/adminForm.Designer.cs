namespace PMS
{
    partial class adminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminForm));
            AddDrugs = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            label4 = new Label();
            button3 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // AddDrugs
            // 
            AddDrugs.BackColor = Color.FromArgb(42, 48, 89);
            AddDrugs.FlatStyle = FlatStyle.Flat;
            AddDrugs.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddDrugs.ForeColor = Color.FromArgb(233, 234, 236);
            AddDrugs.Image = (Image)resources.GetObject("AddDrugs.Image");
            AddDrugs.Location = new Point(35, 170);
            AddDrugs.Name = "AddDrugs";
            AddDrugs.Size = new Size(142, 112);
            AddDrugs.TabIndex = 7;
            AddDrugs.UseVisualStyleBackColor = false;
            AddDrugs.Click += AddDrugs_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(56, 69, 156);
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(233, 234, 236);
            label1.Location = new Point(138, 9);
            label1.Name = "label1";
            label1.Size = new Size(382, 37);
            label1.TabIndex = 10;
            label1.Text = "WELCOME TO ADMIN PANEL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(42, 48, 89);
            label2.Font = new Font("Arial Rounded MT Bold", 12F);
            label2.ForeColor = Color.FromArgb(233, 234, 236);
            label2.Location = new Point(59, 263);
            label2.Name = "label2";
            label2.Size = new Size(89, 18);
            label2.TabIndex = 11;
            label2.Text = "MEDICINE";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(42, 48, 89);
            label3.Font = new Font("Arial Rounded MT Bold", 12F);
            label3.ForeColor = Color.FromArgb(233, 234, 236);
            label3.Location = new Point(281, 263);
            label3.Name = "label3";
            label3.Size = new Size(98, 18);
            label3.TabIndex = 13;
            label3.Text = "EMPLOYEE";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(42, 48, 89);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(233, 234, 236);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(262, 170);
            button2.Name = "button2";
            button2.Size = new Size(133, 112);
            button2.TabIndex = 12;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(42, 48, 89);
            label4.Font = new Font("Arial Rounded MT Bold", 12F);
            label4.ForeColor = Color.FromArgb(233, 234, 236);
            label4.Location = new Point(504, 263);
            label4.Name = "label4";
            label4.Size = new Size(63, 18);
            label4.TabIndex = 15;
            label4.Text = "SALES";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(42, 48, 89);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.FromArgb(233, 234, 236);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(465, 170);
            button3.Name = "button3";
            button3.Size = new Size(139, 112);
            button3.TabIndex = 14;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(56, 69, 156);
            button1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(233, 234, 236);
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(710, 9);
            button1.Name = "button1";
            button1.Size = new Size(93, 37);
            button1.TabIndex = 8;
            button1.Text = " BACK";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // adminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(815, 458);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(AddDrugs);
            Name = "adminForm";
            Text = "adminForm";
            FormClosed += adminForm_FormClosed;
            Load += adminForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddDrugs;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button2;
        private Label label4;
        private Button button3;
        private Button button1;
    }
}