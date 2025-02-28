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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
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
            textBox1.Location = new Point(256, 112);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(237, 23);
            textBox1.TabIndex = 0;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // nm
            // 
            nm.AutoSize = true;
            nm.BackColor = Color.FromArgb(233, 234, 236);
            nm.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            nm.ForeColor = Color.FromArgb(42, 48, 89);
            nm.Location = new Point(169, 118);
            nm.Name = "nm";
            nm.Size = new Size(63, 17);
            nm.TabIndex = 1;
            nm.Text = "USER ID :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(233, 234, 236);
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(42, 48, 89);
            label2.Location = new Point(169, 158);
            label2.Name = "label2";
            label2.Size = new Size(85, 17);
            label2.TabIndex = 2;
            label2.Text = "PASSWORD :";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(256, 152);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(237, 23);
            textBox2.TabIndex = 3;
            // 
            // SignIn
            // 
            SignIn.BackColor = Color.FromArgb(56, 69, 156);
            SignIn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignIn.ForeColor = Color.FromArgb(233, 234, 236);
            SignIn.Location = new Point(219, 226);
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
            checkBox1.BackColor = Color.FromArgb(233, 234, 236);
            checkBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = Color.FromArgb(42, 48, 89);
            checkBox1.Location = new Point(253, 181);
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
            label1.BackColor = Color.FromArgb(233, 234, 236);
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(42, 48, 89);
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
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
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
