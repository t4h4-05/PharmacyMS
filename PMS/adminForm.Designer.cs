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
            AddDrugs.BackColor = Color.Transparent;
            AddDrugs.FlatStyle = FlatStyle.Flat;
            AddDrugs.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddDrugs.Image = (Image)resources.GetObject("AddDrugs.Image");
            AddDrugs.Location = new Point(31, 116);
            AddDrugs.Name = "AddDrugs";
            AddDrugs.Size = new Size(142, 111);
            AddDrugs.TabIndex = 7;
            AddDrugs.UseVisualStyleBackColor = false;
            AddDrugs.Click += AddDrugs_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(141, 9);
            label1.Name = "label1";
            label1.Size = new Size(382, 37);
            label1.TabIndex = 10;
            label1.Text = "WELCOME TO ADMIN PANEL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F);
            label2.Location = new Point(53, 230);
            label2.Name = "label2";
            label2.Size = new Size(89, 18);
            label2.TabIndex = 11;
            label2.Text = "MEDICINE";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F);
            label3.Location = new Point(268, 230);
            label3.Name = "label3";
            label3.Size = new Size(98, 18);
            label3.TabIndex = 13;
            label3.Text = "EMPLOYEE";
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(258, 116);
            button2.Name = "button2";
            button2.Size = new Size(133, 111);
            button2.TabIndex = 12;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12F);
            label4.Location = new Point(498, 230);
            label4.Name = "label4";
            label4.Size = new Size(63, 18);
            label4.TabIndex = 15;
            label4.Text = "SALES";
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(461, 116);
            button3.Name = "button3";
            button3.Size = new Size(139, 111);
            button3.TabIndex = 14;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(507, 339);
            button1.Name = "button1";
            button1.Size = new Size(93, 37);
            button1.TabIndex = 8;
            button1.Text = " BACK";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // adminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(645, 398);
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