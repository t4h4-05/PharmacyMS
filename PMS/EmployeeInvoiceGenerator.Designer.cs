namespace PMS
{
    partial class EmployeeInvoiceGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeInvoiceGenerator));
            lblTotalPrice = new Label();
            listBoxInvoice = new ListBox();
            label5 = new Label();
            txtDiscount = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Add = new Button();
            txtPrice = new TextBox();
            txtType = new TextBox();
            txtName = new TextBox();
            txtReg = new TextBox();
            txtSearch = new TextBox();
            dataGridView1 = new DataGridView();
            btnSave = new Button();
            lblQty = new Label();
            txtQty = new TextBox();
            lblWelcome = new Label();
            btnDel = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPrice.Location = new Point(6, 414);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.RightToLeft = RightToLeft.Yes;
            lblTotalPrice.Size = new Size(127, 32);
            lblTotalPrice.TabIndex = 35;
            lblTotalPrice.Text = "TotalPrice";
            lblTotalPrice.TextAlign = ContentAlignment.MiddleRight;
            lblTotalPrice.Click += lblTotalPrice_Click;
            // 
            // listBoxInvoice
            // 
            listBoxInvoice.FormattingEnabled = true;
            listBoxInvoice.Location = new Point(6, 17);
            listBoxInvoice.Name = "listBoxInvoice";
            listBoxInvoice.Size = new Size(284, 394);
            listBoxInvoice.TabIndex = 34;
            listBoxInvoice.SelectedIndexChanged += listBoxInvoice_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 9.75F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(293, 225);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 33;
            label5.Text = "Discount :";
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(375, 222);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(100, 23);
            txtDiscount.TabIndex = 32;
            txtDiscount.KeyPress += txtDiscount_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9.75F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(293, 167);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 31;
            label4.Text = "Price :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9.75F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(293, 138);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 30;
            label3.Text = "Type :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9.75F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(293, 112);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 29;
            label2.Text = "Name :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 9.75F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(293, 80);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 28;
            label1.Text = "Reg # :";
            // 
            // Add
            // 
            Add.BackColor = Color.FromArgb(192, 255, 255);
            Add.BackgroundImage = Properties.Resources.Basic_Ui__144_;
            Add.BackgroundImageLayout = ImageLayout.Stretch;
            Add.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Add.Location = new Point(395, 251);
            Add.Name = "Add";
            Add.Size = new Size(80, 80);
            Add.TabIndex = 27;
            Add.UseVisualStyleBackColor = false;
            Add.Click += btnAddToInvoice_Click;
            // 
            // txtPrice
            // 
            txtPrice.BackColor = SystemColors.Window;
            txtPrice.Location = new Point(375, 164);
            txtPrice.Name = "txtPrice";
            txtPrice.ReadOnly = true;
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 26;
            // 
            // txtType
            // 
            txtType.BackColor = SystemColors.Window;
            txtType.Location = new Point(375, 135);
            txtType.Name = "txtType";
            txtType.ReadOnly = true;
            txtType.Size = new Size(100, 23);
            txtType.TabIndex = 25;
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.Window;
            txtName.Location = new Point(375, 106);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 24;
            // 
            // txtReg
            // 
            txtReg.BackColor = SystemColors.Window;
            txtReg.Location = new Point(375, 77);
            txtReg.Name = "txtReg";
            txtReg.ReadOnly = true;
            txtReg.Size = new Size(100, 23);
            txtReg.TabIndex = 23;
            txtReg.TextChanged += txtReg_TextChanged;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(544, 28);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(244, 23);
            txtSearch.TabIndex = 20;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(544, 62);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(244, 245);
            dataGridView1.TabIndex = 19;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.KeyDown += dataGridView1_KeyDown;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(192, 255, 255);
            btnSave.BackgroundImage = Properties.Resources._1__7_;
            btnSave.BackgroundImageLayout = ImageLayout.Stretch;
            btnSave.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(708, 313);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(80, 80);
            btnSave.TabIndex = 36;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnPrint_Click;
            // 
            // lblQty
            // 
            lblQty.AutoSize = true;
            lblQty.Font = new Font("Arial Rounded MT Bold", 9.75F);
            lblQty.ForeColor = Color.Black;
            lblQty.Location = new Point(293, 196);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(69, 15);
            lblQty.TabIndex = 38;
            lblQty.Text = "Quantity :";
            // 
            // txtQty
            // 
            txtQty.Location = new Point(375, 193);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(100, 23);
            txtQty.TabIndex = 37;
            txtQty.KeyPress += txtQty_KeyPress;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = SystemColors.ActiveCaptionText;
            lblWelcome.Location = new Point(653, 9);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(64, 17);
            lblWelcome.TabIndex = 39;
            lblWelcome.Text = "Welcome";
            // 
            // btnDel
            // 
            btnDel.BackColor = Color.FromArgb(192, 255, 255);
            btnDel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDel.Location = new Point(293, 384);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(124, 27);
            btnDel.TabIndex = 40;
            btnDel.Text = "Remove Selected";
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += btnDel_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleRight;
            button2.Location = new Point(695, 404);
            button2.Name = "button2";
            button2.Size = new Size(93, 37);
            button2.TabIndex = 46;
            button2.Text = " BACK";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // EmployeeInvoiceGenerator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(btnDel);
            Controls.Add(lblWelcome);
            Controls.Add(lblQty);
            Controls.Add(txtQty);
            Controls.Add(btnSave);
            Controls.Add(lblTotalPrice);
            Controls.Add(listBoxInvoice);
            Controls.Add(label5);
            Controls.Add(txtDiscount);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Add);
            Controls.Add(txtPrice);
            Controls.Add(txtType);
            Controls.Add(txtName);
            Controls.Add(txtReg);
            Controls.Add(txtSearch);
            Controls.Add(dataGridView1);
            MaximizeBox = false;
            Name = "EmployeeInvoiceGenerator";
            Text = "EmployeeInvoiceGenerator";
            FormClosed += EmployeeInvoiceGenerator_FormClosed;
            Load += txtSearch_TextChanged;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTotalPrice;
        private ListBox listBoxInvoice;
        private Label label5;
        private TextBox txtDiscount;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button Add;
        private TextBox txtPrice;
        private TextBox txtType;
        private TextBox txtName;
        private TextBox txtReg;
        private Splitter splitter1;
        private Splitter splitter2;
        private TextBox txtSearch;
        private DataGridView dataGridView1;
        private Button btnSave;
        private Label lblQty;
        private TextBox txtQty;
        private Label lblWelcome;
        private Button btnDel;
        private Button button2;
    }
}