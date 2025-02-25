namespace PMS.AdminStuff
{
    partial class EditDrugs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditDrugs));
            dataGridViewDrugs = new DataGridView();
            txtRegNo = new TextBox();
            txtName = new TextBox();
            txtGName = new TextBox();
            txtType = new TextBox();
            txtTtlSold = new TextBox();
            txtQtyIS = new TextBox();
            txtCPrice = new TextBox();
            txtIPrice = new TextBox();
            BtnEdit = new Button();
            btnDelete = new Button();
            btnLoadData = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDrugs).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewDrugs
            // 
            dataGridViewDrugs.BackgroundColor = Color.White;
            dataGridViewDrugs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDrugs.Location = new Point(12, 303);
            dataGridViewDrugs.Name = "dataGridViewDrugs";
            dataGridViewDrugs.ReadOnly = true;
            dataGridViewDrugs.Size = new Size(796, 173);
            dataGridViewDrugs.TabIndex = 0;
            dataGridViewDrugs.CellClick += dataGridViewDrugs_CellClick;
            // 
            // txtRegNo
            // 
            txtRegNo.Location = new Point(174, 45);
            txtRegNo.Name = "txtRegNo";
            txtRegNo.ReadOnly = true;
            txtRegNo.Size = new Size(100, 23);
            txtRegNo.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(174, 74);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 2;
            // 
            // txtGName
            // 
            txtGName.Location = new Point(174, 103);
            txtGName.Name = "txtGName";
            txtGName.Size = new Size(100, 23);
            txtGName.TabIndex = 3;
            // 
            // txtType
            // 
            txtType.Location = new Point(174, 132);
            txtType.Name = "txtType";
            txtType.Size = new Size(100, 23);
            txtType.TabIndex = 4;
            // 
            // txtTtlSold
            // 
            txtTtlSold.Location = new Point(174, 248);
            txtTtlSold.Name = "txtTtlSold";
            txtTtlSold.ReadOnly = true;
            txtTtlSold.Size = new Size(100, 23);
            txtTtlSold.TabIndex = 8;
            // 
            // txtQtyIS
            // 
            txtQtyIS.Location = new Point(174, 219);
            txtQtyIS.Name = "txtQtyIS";
            txtQtyIS.Size = new Size(100, 23);
            txtQtyIS.TabIndex = 7;
            // 
            // txtCPrice
            // 
            txtCPrice.Location = new Point(174, 190);
            txtCPrice.Name = "txtCPrice";
            txtCPrice.Size = new Size(100, 23);
            txtCPrice.TabIndex = 6;
            // 
            // txtIPrice
            // 
            txtIPrice.Location = new Point(174, 161);
            txtIPrice.Name = "txtIPrice";
            txtIPrice.Size = new Size(100, 23);
            txtIPrice.TabIndex = 5;
            // 
            // BtnEdit
            // 
            BtnEdit.BackColor = Color.FromArgb(192, 255, 255);
            BtnEdit.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnEdit.Image = (Image)resources.GetObject("BtnEdit.Image");
            BtnEdit.ImageAlign = ContentAlignment.MiddleLeft;
            BtnEdit.Location = new Point(378, 110);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(137, 52);
            BtnEdit.TabIndex = 9;
            BtnEdit.Text = "EDIT";
            BtnEdit.UseVisualStyleBackColor = false;
            BtnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(192, 255, 255);
            btnDelete.Font = new Font("Arial Rounded MT Bold", 12F);
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(378, 185);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(137, 52);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnLoadData
            // 
            btnLoadData.BackColor = Color.FromArgb(192, 255, 255);
            btnLoadData.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLoadData.Location = new Point(752, 12);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new Size(89, 30);
            btnLoadData.TabIndex = 11;
            btnLoadData.Text = "RELOAD";
            btnLoadData.UseVisualStyleBackColor = false;
            btnLoadData.Click += EditDrugs_Load;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(66, 48);
            label1.Name = "label1";
            label1.Size = new Size(60, 17);
            label1.TabIndex = 13;
            label1.Text = "Reg No :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(66, 75);
            label2.Name = "label2";
            label2.Size = new Size(91, 17);
            label2.TabIndex = 14;
            label2.Text = "Brand Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(66, 104);
            label3.Name = "label3";
            label3.Size = new Size(100, 17);
            label3.TabIndex = 15;
            label3.Text = "Generic Name :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(66, 133);
            label4.Name = "label4";
            label4.Size = new Size(43, 17);
            label4.TabIndex = 16;
            label4.Text = "Type :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(66, 162);
            label5.Name = "label5";
            label5.Size = new Size(95, 17);
            label5.TabIndex = 17;
            label5.Text = "Internal Price :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(66, 191);
            label6.Name = "label6";
            label6.Size = new Size(81, 17);
            label6.TabIndex = 18;
            label6.Text = "Retail Price :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(66, 220);
            label7.Name = "label7";
            label7.Size = new Size(89, 17);
            label7.TabIndex = 19;
            label7.Text = "Qty in Stock :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(66, 249);
            label8.Name = "label8";
            label8.Size = new Size(74, 17);
            label8.TabIndex = 20;
            label8.Text = "Total Sold :";
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(715, 260);
            button1.Name = "button1";
            button1.Size = new Size(93, 37);
            button1.TabIndex = 44;
            button1.Text = " BACK";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // EditDrugs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(853, 488);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLoadData);
            Controls.Add(btnDelete);
            Controls.Add(BtnEdit);
            Controls.Add(txtTtlSold);
            Controls.Add(txtQtyIS);
            Controls.Add(txtCPrice);
            Controls.Add(txtIPrice);
            Controls.Add(txtType);
            Controls.Add(txtGName);
            Controls.Add(txtName);
            Controls.Add(txtRegNo);
            Controls.Add(dataGridViewDrugs);
            Name = "EditDrugs";
            Text = "EditDrugs";
            FormClosed += EditDrugs_FormClosed;
            Load += EditDrugs_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewDrugs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewDrugs;
        private TextBox txtRegNo;
        private TextBox txtName;
        private TextBox txtGName;
        private TextBox txtType;
        private TextBox txtTtlSold;
        private TextBox txtQtyIS;
        private TextBox txtCPrice;
        private TextBox txtIPrice;
        private Button BtnEdit;
        private Button btnDelete;
        private Button btnLoadData;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button1;
    }
}