namespace PMS
{
    partial class EmployeeForm
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
            splitContainer1 = new SplitContainer();
            richTextBox1 = new RichTextBox();
            splitter2 = new Splitter();
            textBox1 = new TextBox();
            button1 = new Button();
            splitter1 = new Splitter();
            dataGridView1 = new DataGridView();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            textBox4 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(textBox4);
            splitContainer1.Panel1.Controls.Add(textBox3);
            splitContainer1.Panel1.Controls.Add(textBox2);
            splitContainer1.Panel1.Controls.Add(dataGridView1);
            splitContainer1.Panel1.Controls.Add(richTextBox1);
            splitContainer1.Panel1.Controls.Add(splitter2);
            splitContainer1.Panel1.Controls.Add(textBox1);
            splitContainer1.Panel1.Controls.Add(button1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(splitter1);
            splitContainer1.Size = new Size(981, 502);
            splitContainer1.SplitterDistance = 584;
            splitContainer1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(560, 59);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // splitter2
            // 
            splitter2.Dock = DockStyle.Top;
            splitter2.Location = new Point(0, 0);
            splitter2.Name = "splitter2";
            splitter2.Size = new Size(584, 81);
            splitter2.TabIndex = 2;
            splitter2.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 87);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(240, 23);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(464, 254);
            button1.Name = "button1";
            button1.Size = new Size(108, 36);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // splitter1
            // 
            splitter1.Dock = DockStyle.Bottom;
            splitter1.Location = new Point(0, 361);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(393, 141);
            splitter1.TabIndex = 0;
            splitter1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 116);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(240, 374);
            dataGridView1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(426, 116);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(146, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(464, 157);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(108, 23);
            textBox3.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(313, 462);
            label1.Name = "label1";
            label1.Size = new Size(68, 28);
            label1.TabIndex = 1;
            label1.Text = "8080";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(464, 200);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(108, 23);
            textBox4.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(313, 119);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 8;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(313, 165);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 9;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(313, 208);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 10;
            label4.Text = "label4";
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(981, 502);
            Controls.Add(splitContainer1);
            Name = "EmployeeForm";
            Text = "Form2";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Splitter splitter1;
        private TextBox textBox1;
        private Button button1;
        private RichTextBox richTextBox1;
        private Splitter splitter2;
        private TextBox textBox3;
        private TextBox textBox2;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox4;
    }
}