namespace PMS.AdminStuff.Drugs
{
    partial class EditPrice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPrice));
            dataGridView1 = new DataGridView();
            txtName = new TextBox();
            txtIPrice = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtCPrice = new TextBox();
            btnUpdatePrice = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(35, 29);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(299, 394);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // txtName
            // 
            txtName.Location = new Point(482, 87);
            txtName.Name = "txtName";
            txtName.Size = new Size(151, 23);
            txtName.TabIndex = 1;
            // 
            // txtIPrice
            // 
            txtIPrice.Location = new Point(482, 141);
            txtIPrice.Name = "txtIPrice";
            txtIPrice.Size = new Size(151, 23);
            txtIPrice.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 9.75F);
            label1.Location = new Point(360, 90);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 3;
            label1.Text = "Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9.75F);
            label2.Location = new Point(360, 149);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 4;
            label2.Text = "Internal Price :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9.75F);
            label3.Location = new Point(360, 193);
            label3.Name = "label3";
            label3.Size = new Size(119, 15);
            label3.TabIndex = 6;
            label3.Text = "Consumer Price :";
            // 
            // txtCPrice
            // 
            txtCPrice.Location = new Point(482, 190);
            txtCPrice.Name = "txtCPrice";
            txtCPrice.Size = new Size(151, 23);
            txtCPrice.TabIndex = 5;
            // 
            // btnUpdatePrice
            // 
            btnUpdatePrice.BackColor = Color.FromArgb(192, 255, 255);
            btnUpdatePrice.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdatePrice.Image = (Image)resources.GetObject("btnUpdatePrice.Image");
            btnUpdatePrice.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdatePrice.Location = new Point(482, 245);
            btnUpdatePrice.Name = "btnUpdatePrice";
            btnUpdatePrice.Size = new Size(156, 52);
            btnUpdatePrice.TabIndex = 7;
            btnUpdatePrice.Text = "UPDATE";
            btnUpdatePrice.UseVisualStyleBackColor = false;
            btnUpdatePrice.Click += btnUpdatePrice_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(672, 386);
            button1.Name = "button1";
            button1.Size = new Size(93, 37);
            button1.TabIndex = 43;
            button1.Text = " BACK";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // EditPrice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnUpdatePrice);
            Controls.Add(label3);
            Controls.Add(txtCPrice);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtIPrice);
            Controls.Add(txtName);
            Controls.Add(dataGridView1);
            Name = "EditPrice";
            Text = "EditPrice";
            FormClosed += EditPrice_FormClosed;
            Load += EditPrice_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtName;
        private TextBox txtIPrice;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCPrice;
        private Button btnUpdatePrice;
        private Button button1;
    }
}