namespace PMS.AdminStuff.Sales
{
    partial class SalesDrug
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesDrug));
            dataGridViewDrugs = new DataGridView();
            chartDrugsSold = new System.Windows.Forms.DataVisualization.Charting.Chart();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDrugs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartDrugsSold).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewDrugs
            // 
            dataGridViewDrugs.BackgroundColor = Color.White;
            dataGridViewDrugs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDrugs.Location = new Point(12, 54);
            dataGridViewDrugs.Name = "dataGridViewDrugs";
            dataGridViewDrugs.Size = new Size(383, 471);
            dataGridViewDrugs.TabIndex = 0;
            dataGridViewDrugs.CellClick += dataGridViewDrugs_CellClick;
            // 
            // chartDrugsSold
            // 
            chartArea1.Name = "ChartArea1";
            chartDrugsSold.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartDrugsSold.Legends.Add(legend1);
            chartDrugsSold.Location = new Point(401, 54);
            chartDrugsSold.Name = "chartDrugsSold";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartDrugsSold.Series.Add(series1);
            chartDrugsSold.Size = new Size(530, 471);
            chartDrugsSold.TabIndex = 1;
            chartDrugsSold.Text = "chart1";
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(838, 11);
            button1.Name = "button1";
            button1.Size = new Size(93, 37);
            button1.TabIndex = 30;
            button1.Text = " BACK";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += Back_Click;
            // 
            // SalesDrug
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(943, 537);
            Controls.Add(button1);
            Controls.Add(chartDrugsSold);
            Controls.Add(dataGridViewDrugs);
            Name = "SalesDrug";
            Text = "SalesDrug";
            Load += SalesDrug_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewDrugs).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartDrugsSold).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewDrugs;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDrugsSold;
        private Button button1;
    }
}