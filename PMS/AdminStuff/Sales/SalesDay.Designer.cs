namespace PMS.AdminStuff.Sales
{
    partial class SalesDay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesDay));
            chartSales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            Back = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)chartSales).BeginInit();
            SuspendLayout();
            // 
            // chartSales
            // 
            chartArea1.Name = "ChartArea1";
            chartSales.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartSales.Legends.Add(legend1);
            chartSales.Location = new Point(12, 52);
            chartSales.Name = "chartSales";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartSales.Series.Add(series1);
            chartSales.Size = new Size(776, 396);
            chartSales.TabIndex = 0;
            chartSales.Text = "chartSales";
            // 
            // Back
            // 
            Back.BackColor = Color.Black;
            Back.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Back.ForeColor = Color.White;
            Back.Image = (Image)resources.GetObject("Back.Image");
            Back.ImageAlign = ContentAlignment.MiddleRight;
            Back.Location = new Point(695, 9);
            Back.Name = "Back";
            Back.Size = new Size(93, 37);
            Back.TabIndex = 9;
            Back.Text = " BACK";
            Back.TextAlign = ContentAlignment.MiddleLeft;
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 9.75F);
            label1.Location = new Point(35, 20);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 10;
            label1.Text = "Total Sales :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9.75F);
            label2.Location = new Point(250, 20);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 11;
            label2.Text = "Total Revenue :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9.75F);
            label3.Location = new Point(452, 20);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 12;
            label3.Text = "Total Profit :";
            // 
            // SalesDay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Back);
            Controls.Add(chartSales);
            Name = "SalesDay";
            Text = "SalesDay";
            Load += SalesDay_Load;
            ((System.ComponentModel.ISupportInitialize)chartSales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartSales;
        private Button Back;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}