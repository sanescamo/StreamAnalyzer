namespace WF_Stream_Analyzer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView_table = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Memory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payload = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Counter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_table)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Location = new System.Drawing.Point(65, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 49);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.Location = new System.Drawing.Point(121, 14);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(51, 49);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.Location = new System.Drawing.Point(178, 14);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(51, 49);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.Location = new System.Drawing.Point(235, 14);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(51, 49);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.Location = new System.Drawing.Point(292, 14);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(51, 49);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Location = new System.Drawing.Point(6, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 49);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView_table
            // 
            this.dataGridView_table.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.Memory,
            this.Type,
            this.PID,
            this.Payload,
            this.Counter});
            this.dataGridView_table.Location = new System.Drawing.Point(327, 118);
            this.dataGridView_table.Name = "dataGridView_table";
            this.dataGridView_table.RowHeadersVisible = false;
            this.dataGridView_table.Size = new System.Drawing.Size(803, 344);
            this.dataGridView_table.TabIndex = 6;
            this.dataGridView_table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // No
            // 
            this.No.HeaderText = "No.";
            this.No.Name = "No";
            // 
            // Memory
            // 
            this.Memory.HeaderText = "Memory";
            this.Memory.Name = "Memory";
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.Width = 300;
            // 
            // PID
            // 
            this.PID.HeaderText = "PID";
            this.PID.Name = "PID";
            // 
            // Payload
            // 
            this.Payload.HeaderText = "Payload";
            this.Payload.Name = "Payload";
            // 
            // Counter
            // 
            this.Counter.HeaderText = "Counter";
            this.Counter.Name = "Counter";
            // 
            // button7
            // 
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.Location = new System.Drawing.Point(349, 14);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(51, 49);
            this.button7.TabIndex = 7;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(30, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1100, 73);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(240, 20);
            this.textBox1.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(30, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 157);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "StreamInfo";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(23, 55);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(240, 78);
            this.textBox2.TabIndex = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.treeView1);
            this.groupBox3.Controls.Add(this.button11);
            this.groupBox3.Controls.Add(this.button10);
            this.groupBox3.Controls.Add(this.button9);
            this.groupBox3.Controls.Add(this.button8);
            this.groupBox3.Location = new System.Drawing.Point(30, 354);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(278, 458);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(20, 86);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(240, 355);
            this.treeView1.TabIndex = 4;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(151, 57);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(109, 23);
            this.button11.TabIndex = 3;
            this.button11.Text = "Close all";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(20, 57);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(109, 23);
            this.button10.TabIndex = 2;
            this.button10.Text = "Hide all";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(151, 28);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(109, 23);
            this.button9.TabIndex = 1;
            this.button9.Text = "Open all";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(20, 28);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(109, 23);
            this.button8.TabIndex = 0;
            this.button8.Text = "Show all";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // treeView2
            // 
            this.treeView2.Location = new System.Drawing.Point(327, 466);
            this.treeView2.Name = "treeView2";
            this.treeView2.Size = new System.Drawing.Size(803, 329);
            this.treeView2.TabIndex = 12;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(23, 22);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(240, 23);
            this.progressBar1.TabIndex = 13;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.progressBar1);
            this.groupBox4.Location = new System.Drawing.Point(30, 283);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(278, 57);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Parsing progress";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 845);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.treeView2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView_table);
            this.Name = "Form1";
            this.Text = "Stream Analyzer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_table)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView_table;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Memory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn PID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payload;
        private System.Windows.Forms.DataGridViewTextBoxColumn Counter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

