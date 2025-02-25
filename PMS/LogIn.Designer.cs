namespace PMS
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            nm = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            SignIn = new Button();
            checkBox1 = new CheckBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(321, 131);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(237, 23);
            textBox1.TabIndex = 0;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // nm
            // 
            nm.AutoSize = true;
            nm.BackColor = Color.Transparent;
            nm.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            nm.ForeColor = SystemColors.ActiveCaptionText;
            nm.Location = new Point(234, 137);
            nm.Name = "nm";
            nm.Size = new Size(63, 17);
            nm.TabIndex = 1;
            nm.Text = "USER ID :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(234, 177);
            label2.Name = "label2";
            label2.Size = new Size(85, 17);
            label2.TabIndex = 2;
            label2.Text = "PASSWORD :";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(321, 171);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(237, 23);
            textBox2.TabIndex = 3;
            // 
            // SignIn
            // 
            SignIn.BackColor = Color.White;
            SignIn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignIn.ForeColor = Color.Black;
            SignIn.Location = new Point(321, 245);
            SignIn.Name = "SignIn";
            SignIn.Size = new Size(240, 50);
            SignIn.TabIndex = 5;
            SignIn.Text = "SIGN-IN";
            SignIn.UseVisualStyleBackColor = false;
            SignIn.Click += SignIn_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = SystemColors.ActiveCaptionText;
            checkBox1.Location = new Point(318, 200);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(82, 19);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Show Pass";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(109, 9);
            label1.Name = "label1";
            label1.Size = new Size(481, 37);
            label1.TabIndex = 7;
            label1.Text = "PHARMACY MANAGEMENT SYSTEM";
            label1.Click += label1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            BackgroundImage = Properties.Resources.wengang_zhai_BFB7ydn1_DI_unsplash;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(684, 363);
            Controls.Add(label1);
            Controls.Add(checkBox1);
            Controls.Add(SignIn);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(nm);
            Controls.Add(textBox1);
            Name = "Login";
            Text = "Form1";
            FormClosed += Login_FormClosed;
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label nm;
        private Label label2;
        private TextBox textBox2;
        private Button SignIn;
        private CheckBox checkBox1;
        private Label label1;
    }
}
