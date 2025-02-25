namespace PMS.AdminStuff
{
    partial class EditEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditEmployee));
            dataGridView1 = new DataGridView();
            txtSearch = new TextBox();
            btnSeach = new Button();
            txtId = new TextBox();
            txtName = new TextBox();
            txtPassword = new TextBox();
            txtAge = new TextBox();
            txtRoll = new TextBox();
            btnEdit = new Button();
            btnDelete = new Button();
            btnLoad = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnClrID = new Button();
            label7 = new Label();
            txtMonthlySalary = new TextBox();
            btnAdd = new Button();
            rb_isA = new RadioButton();
            rb_isE = new RadioButton();
            txtAccessLvl = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 296);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(834, 185);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 17);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(259, 23);
            txtSearch.TabIndex = 1;
            // 
            // btnSeach
            // 
            btnSeach.BackColor = Color.FromArgb(192, 255, 255);
            btnSeach.Font = new Font("Arial Rounded MT Bold", 9F);
            btnSeach.Location = new Point(277, 12);
            btnSeach.Name = "btnSeach";
            btnSeach.Size = new Size(89, 30);
            btnSeach.TabIndex = 2;
            btnSeach.Text = "SEARCH";
            btnSeach.UseVisualStyleBackColor = false;
            btnSeach.Click += btnSearch_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(235, 65);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(259, 23);
            txtId.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Location = new Point(235, 94);
            txtName.Name = "txtName";
            txtName.Size = new Size(259, 23);
            txtName.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(235, 123);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(259, 23);
            txtPassword.TabIndex = 5;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(235, 152);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(259, 23);
            txtAge.TabIndex = 6;
            // 
            // txtRoll
            // 
            txtRoll.Location = new Point(235, 181);
            txtRoll.Name = "txtRoll";
            txtRoll.Size = new Size(259, 23);
            txtRoll.TabIndex = 7;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(192, 255, 255);
            btnEdit.Font = new Font("Arial Rounded MT Bold", 12F);
            btnEdit.Image = (Image)resources.GetObject("btnEdit.Image");
            btnEdit.ImageAlign = ContentAlignment.MiddleLeft;
            btnEdit.Location = new Point(623, 114);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(156, 52);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "UPDATE";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(192, 255, 255);
            btnDelete.Font = new Font("Arial Rounded MT Bold", 12F);
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(623, 172);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(156, 52);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.FromArgb(192, 255, 255);
            btnLoad.Font = new Font("Arial Rounded MT Bold", 9F);
            btnLoad.Location = new Point(713, 12);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(89, 30);
            btnLoad.TabIndex = 12;
            btnLoad.Text = "RELOAD";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 9.75F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(101, 68);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 13;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9.75F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(101, 97);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 14;
            label2.Text = "NAME:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9.75F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(101, 126);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 15;
            label3.Text = "PASWORD:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9.75F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(101, 155);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 16;
            label4.Text = "AGE:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 9.75F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(101, 184);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 17;
            label5.Text = "REG NO:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 9.75F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(101, 213);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 18;
            label6.Text = "ROLE :";
            // 
            // btnClrID
            // 
            btnClrID.BackColor = Color.FromArgb(192, 255, 255);
            btnClrID.Font = new Font("Arial Rounded MT Bold", 9F);
            btnClrID.Location = new Point(500, 64);
            btnClrID.Name = "btnClrID";
            btnClrID.Size = new Size(89, 30);
            btnClrID.TabIndex = 19;
            btnClrID.Text = "CLEAR";
            btnClrID.UseVisualStyleBackColor = false;
            btnClrID.Click += btnClrID_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 9.75F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(101, 242);
            label7.Name = "label7";
            label7.Size = new Size(131, 15);
            label7.TabIndex = 21;
            label7.Text = "MONTHLY SALARY:";
            // 
            // txtMonthlySalary
            // 
            txtMonthlySalary.ImeMode = ImeMode.Off;
            txtMonthlySalary.Location = new Point(235, 239);
            txtMonthlySalary.Name = "txtMonthlySalary";
            txtMonthlySalary.Size = new Size(259, 23);
            txtMonthlySalary.TabIndex = 20;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(192, 255, 255);
            btnAdd.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(623, 59);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(156, 49);
            btnAdd.TabIndex = 23;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // rb_isA
            // 
            rb_isA.AutoSize = true;
            rb_isA.Font = new Font("Arial Rounded MT Bold", 9F);
            rb_isA.ForeColor = Color.Black;
            rb_isA.Location = new Point(235, 209);
            rb_isA.Name = "rb_isA";
            rb_isA.Size = new Size(63, 18);
            rb_isA.TabIndex = 24;
            rb_isA.TabStop = true;
            rb_isA.Text = "Admin";
            rb_isA.UseVisualStyleBackColor = true;
            rb_isA.CheckedChanged += rb_isA_CheckedChanged;
            // 
            // rb_isE
            // 
            rb_isE.AutoSize = true;
            rb_isE.Font = new Font("Arial Rounded MT Bold", 9F);
            rb_isE.ForeColor = Color.Black;
            rb_isE.Location = new Point(335, 210);
            rb_isE.Name = "rb_isE";
            rb_isE.Size = new Size(83, 18);
            rb_isE.TabIndex = 25;
            rb_isE.TabStop = true;
            rb_isE.Text = "Employee";
            rb_isE.UseVisualStyleBackColor = true;
            rb_isE.CheckedChanged += rb_isE_CheckedChanged;
            // 
            // txtAccessLvl
            // 
            txtAccessLvl.ImeMode = ImeMode.Off;
            txtAccessLvl.Location = new Point(235, 267);
            txtAccessLvl.Name = "txtAccessLvl";
            txtAccessLvl.Size = new Size(259, 23);
            txtAccessLvl.TabIndex = 27;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(756, 253);
            button1.Name = "button1";
            button1.Size = new Size(93, 37);
            button1.TabIndex = 28;
            button1.Text = " BACK";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // EditEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(861, 504);
            Controls.Add(button1);
            Controls.Add(txtAccessLvl);
            Controls.Add(rb_isE);
            Controls.Add(rb_isA);
            Controls.Add(btnAdd);
            Controls.Add(label7);
            Controls.Add(txtMonthlySalary);
            Controls.Add(btnClrID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLoad);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(txtRoll);
            Controls.Add(txtAge);
            Controls.Add(txtPassword);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(btnSeach);
            Controls.Add(txtSearch);
            Controls.Add(dataGridView1);
            Name = "EditEmployee";
            Text = "`";
            FormClosed += EditEmployee_FormClosed;
            Load += btnLoad_Click;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtSearch;
        private Button btnSeach;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtPassword;
        private TextBox txtAge;
        private TextBox txtRoll;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnLoad;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnClrID;
        private Label label7;
        private TextBox txtMonthlySalary;
        private Button btnAdd;
        private RadioButton rb_isA;
        private RadioButton rb_isE;
        private TextBox txtAccessLvl;
        private Button button1;
    }
}