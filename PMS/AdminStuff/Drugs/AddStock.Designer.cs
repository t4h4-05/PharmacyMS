namespace PMS.AdminStuff
{
    partial class AddStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStock));
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            addDrugs = new RadioButton();
            remDrugs = new RadioButton();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Arial Rounded MT Bold", 9F);
            label1.Location = new Point(34, 56);
            label1.Name = "label1";
            label1.Size = new Size(57, 14);
            label1.TabIndex = 0;
            label1.Text = "Reg No :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(107, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(182, 23);
            textBox1.TabIndex = 1;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Arial Rounded MT Bold", 9F);
            label2.Location = new Point(34, 118);
            label2.Name = "label2";
            label2.Size = new Size(59, 14);
            label2.TabIndex = 2;
            label2.Text = "Amount :";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(107, 117);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(182, 23);
            textBox2.TabIndex = 3;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 255);
            button1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(70, 208);
            button1.Name = "button1";
            button1.Size = new Size(165, 37);
            button1.TabIndex = 4;
            button1.Text = "ADD/REMOVE";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // addDrugs
            // 
            addDrugs.AutoSize = true;
            addDrugs.BackColor = Color.FromArgb(192, 255, 255);
            addDrugs.Checked = true;
            addDrugs.Font = new Font("Arial Rounded MT Bold", 9F);
            addDrugs.Location = new Point(70, 164);
            addDrugs.Name = "addDrugs";
            addDrugs.Size = new Size(50, 18);
            addDrugs.TabIndex = 5;
            addDrugs.TabStop = true;
            addDrugs.Text = "Add";
            addDrugs.UseVisualStyleBackColor = false;
            addDrugs.CheckedChanged += addDrugs_CheckedChanged;
            // 
            // remDrugs
            // 
            remDrugs.AutoSize = true;
            remDrugs.BackColor = Color.FromArgb(192, 255, 255);
            remDrugs.Font = new Font("Arial Rounded MT Bold", 9F);
            remDrugs.Location = new Point(181, 164);
            remDrugs.Name = "remDrugs";
            remDrugs.Size = new Size(73, 18);
            remDrugs.TabIndex = 6;
            remDrugs.Text = "Remove";
            remDrugs.UseVisualStyleBackColor = false;
            remDrugs.CheckedChanged += remDrugs_CheckedChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleRight;
            button2.Location = new Point(12, 309);
            button2.Name = "button2";
            button2.Size = new Size(93, 37);
            button2.TabIndex = 45;
            button2.Text = " BACK";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // AddStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(472, 358);
            Controls.Add(button2);
            Controls.Add(remDrugs);
            Controls.Add(addDrugs);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "AddStock";
            Text = "AddStock";
            FormClosed += AddStock_FormClosed;
            Load += AddStock_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Button button1;
        private RadioButton addDrugs;
        private RadioButton remDrugs;
        private Button button2;
    }
}