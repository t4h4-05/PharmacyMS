namespace PMS.AdminStuff
{
    partial class ViewEmp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewEmp));
            button1 = new Button();
            btnRst = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(723, 6);
            button1.Name = "button1";
            button1.Size = new Size(93, 37);
            button1.TabIndex = 48;
            button1.Text = " BACK";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnRst
            // 
            btnRst.BackColor = Color.FromArgb(192, 255, 255);
            btnRst.Font = new Font("Arial Rounded MT Bold", 9F);
            btnRst.Location = new Point(528, 19);
            btnRst.Name = "btnRst";
            btnRst.Size = new Size(89, 30);
            btnRst.TabIndex = 47;
            btnRst.Text = "RESET";
            btnRst.UseVisualStyleBackColor = false;
            btnRst.Click += btnLoadData_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(192, 255, 255);
            btnSearch.Font = new Font("Arial Rounded MT Bold", 9F);
            btnSearch.Location = new Point(433, 19);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(89, 30);
            btnSearch.TabIndex = 46;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 23);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(411, 23);
            txtSearch.TabIndex = 45;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.EditMode = DataGridViewEditMode.EditOnKeystroke;
            dataGridView1.Location = new Point(0, 72);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(839, 378);
            dataGridView1.TabIndex = 44;
            // 
            // ViewEmp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 450);
            Controls.Add(button1);
            Controls.Add(btnRst);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(dataGridView1);
            Name = "ViewEmp";
            Text = "ViewEmp";
            FormClosed += ViewEmployees_FormClosed;
            Load += ViewEmployees_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btnRst;
        private Button btnSearch;
        private TextBox txtSearch;
        private DataGridView dataGridView1;
    }
}