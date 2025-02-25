namespace PMS.AdminStuff
{
    partial class AddDrugs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDrugs));
            Title = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            textBox6 = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.ForeColor = Color.Black;
            Title.Location = new Point(74, 9);
            Title.Name = "Title";
            Title.Size = new Size(88, 21);
            Title.TabIndex = 0;
            Title.Text = "Add Drugs";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 9.75F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 88);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 1;
            label1.Text = "Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9.75F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(12, 183);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 2;
            label2.Text = "Our Price :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9.75F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(12, 234);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 3;
            label3.Text = "Quantity :";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9.75F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(12, 283);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 4;
            label4.Text = "Selling Price :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(137, 80);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(137, 129);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(137, 175);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 7;
            textBox3.KeyPress += textBox3_KeyPress;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(137, 229);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 8;
            textBox4.KeyPress += textBox4_KeyPress;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(137, 275);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 9;
            textBox5.KeyPress += textBox5_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 9.75F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(12, 137);
            label5.Name = "label5";
            label5.Size = new Size(107, 15);
            label5.TabIndex = 9;
            label5.Text = "Generic Name :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 9.75F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(12, 329);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 11;
            label6.Text = "Type :";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 255);
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 365);
            button1.Name = "button1";
            button1.Size = new Size(225, 37);
            button1.TabIndex = 11;
            button1.Text = "ADD DRUGS";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(137, 321);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 10;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleRight;
            button2.Location = new Point(144, 422);
            button2.Name = "button2";
            button2.Size = new Size(93, 37);
            button2.TabIndex = 46;
            button2.Text = " BACK";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // AddDrugs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(249, 471);
            Controls.Add(button2);
            Controls.Add(textBox6);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Title);
            Name = "AddDrugs";
            Text = "AddDrugs";
            FormClosed += AddDrugs_FormClosed;
            Load += AddDrugs_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label5;
        private Label label6;
        private Button button1;
        private TextBox textBox6;
        private Button button2;
    }
}