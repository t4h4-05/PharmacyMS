namespace PMS.AdminStuff.Employee
{
    partial class RaiseEmp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RaiseEmp));
            dataGridView1 = new DataGridView();
            txtRaiseAmount = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 207);
            dataGridView1.TabIndex = 0;
            // 
            // txtRaiseAmount
            // 
            txtRaiseAmount.Location = new Point(179, 249);
            txtRaiseAmount.Name = "txtRaiseAmount";
            txtRaiseAmount.Size = new Size(146, 23);
            txtRaiseAmount.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(52, 252);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 2;
            label1.Text = "Raise amount :";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 255);
            button1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(158, 292);
            button1.Name = "button1";
            button1.Size = new Size(186, 52);
            button1.TabIndex = 3;
            button1.Text = "APPROVE RAISE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnApplyRaise_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleRight;
            button2.Location = new Point(695, 363);
            button2.Name = "button2";
            button2.Size = new Size(93, 37);
            button2.TabIndex = 29;
            button2.Text = " BACK";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // RaiseEmp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 412);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(txtRaiseAmount);
            Controls.Add(dataGridView1);
            Name = "RaiseEmp";
            Text = "RaiseEmp";
            FormClosed += RaiseEmp_FormClosed;
            Load += GiveRaise_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtRaiseAmount;
        private Label label1;
        private Button button1;
        private Button button2;
    }
}