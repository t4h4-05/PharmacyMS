namespace PMS.AdminStuff
{
    partial class EmployeePerformance
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeePerformance));
            dataGridViewEmployee = new DataGridView();
            lblEmpID = new Label();
            lblEmpName = new Label();
            lblTotalRevenue = new Label();
            lblTotalProfit = new Label();
            chartPerformance = new System.Windows.Forms.DataVisualization.Charting.Chart();
            txtSearch = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartPerformance).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewEmployee
            // 
            dataGridViewEmployee.BackgroundColor = Color.White;
            dataGridViewEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmployee.Location = new Point(12, 65);
            dataGridViewEmployee.Name = "dataGridViewEmployee";
            dataGridViewEmployee.ReadOnly = true;
            dataGridViewEmployee.Size = new Size(255, 470);
            dataGridViewEmployee.TabIndex = 0;
            dataGridViewEmployee.CellClick += dataGridViewEmployee_CellClick;
            // 
            // lblEmpID
            // 
            lblEmpID.AutoSize = true;
            lblEmpID.BackColor = Color.White;
            lblEmpID.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lblEmpID.Location = new Point(437, 41);
            lblEmpID.Name = "lblEmpID";
            lblEmpID.Size = new Size(0, 25);
            lblEmpID.TabIndex = 5;
            // 
            // lblEmpName
            // 
            lblEmpName.AutoSize = true;
            lblEmpName.BackColor = Color.White;
            lblEmpName.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lblEmpName.Location = new Point(437, 70);
            lblEmpName.Name = "lblEmpName";
            lblEmpName.Size = new Size(0, 25);
            lblEmpName.TabIndex = 6;
            // 
            // lblTotalRevenue
            // 
            lblTotalRevenue.AutoSize = true;
            lblTotalRevenue.BackColor = Color.White;
            lblTotalRevenue.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lblTotalRevenue.Location = new Point(716, 41);
            lblTotalRevenue.Name = "lblTotalRevenue";
            lblTotalRevenue.Size = new Size(0, 25);
            lblTotalRevenue.TabIndex = 8;
            // 
            // lblTotalProfit
            // 
            lblTotalProfit.AutoSize = true;
            lblTotalProfit.BackColor = Color.White;
            lblTotalProfit.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lblTotalProfit.Location = new Point(716, 70);
            lblTotalProfit.Name = "lblTotalProfit";
            lblTotalProfit.Size = new Size(0, 25);
            lblTotalProfit.TabIndex = 10;
            // 
            // chartPerformance
            // 
            chartPerformance.BackColor = Color.Gray;
            chartArea1.Name = "ChartArea1";
            chartPerformance.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartPerformance.Legends.Add(legend1);
            chartPerformance.Location = new Point(273, 116);
            chartPerformance.Name = "chartPerformance";
            chartPerformance.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartPerformance.Series.Add(series1);
            chartPerformance.Size = new Size(704, 419);
            chartPerformance.TabIndex = 13;
            chartPerformance.Text = "chartPerformance";
            chartPerformance.Click += chartPerformance_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 33);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(255, 23);
            txtSearch.TabIndex = 14;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label1.Location = new Point(570, 41);
            label1.Name = "label1";
            label1.Size = new Size(106, 25);
            label1.TabIndex = 19;
            label1.Text = "Total Sales ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label2.Location = new Point(570, 70);
            label2.Name = "label2";
            label2.Size = new Size(131, 25);
            label2.TabIndex = 18;
            label2.Text = "Total Revenue";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label4.Location = new Point(311, 70);
            label4.Name = "label4";
            label4.Size = new Size(64, 25);
            label4.TabIndex = 16;
            label4.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label5.Location = new Point(311, 41);
            label5.Name = "label5";
            label5.Size = new Size(42, 25);
            label5.TabIndex = 15;
            label5.Text = "ID :";
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(884, 12);
            button1.Name = "button1";
            button1.Size = new Size(93, 37);
            button1.TabIndex = 24;
            button1.Text = " BACK";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // EmployeePerformance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(989, 547);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(txtSearch);
            Controls.Add(chartPerformance);
            Controls.Add(lblTotalProfit);
            Controls.Add(lblTotalRevenue);
            Controls.Add(lblEmpName);
            Controls.Add(lblEmpID);
            Controls.Add(dataGridViewEmployee);
            Name = "EmployeePerformance";
            Text = "EmployeePerformance";
            FormClosed += EmployeePerformance_FormClosed;
            Load += txtSearch_TextChanged;
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployee).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartPerformance).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewEmployee;
        private Label lblEmpID;
        private Label lblEmpName;
        private Label lblTotalRevenue;
        private Label lblTotalProfit;
        private Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPerformance;
        private TextBox txtSearch;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Button button1;
    }
}