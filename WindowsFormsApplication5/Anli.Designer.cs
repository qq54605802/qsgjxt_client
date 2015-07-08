namespace WindowsFormsApplication5
{
    partial class Anli
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxANWEIZHI = new System.Windows.Forms.TextBox();
            this.textBoxANLILOUCENG = new System.Windows.Forms.TextBox();
            this.textBoxANLIZONGCENG = new System.Windows.Forms.TextBox();
            this.textBoxANLIMIANJI = new System.Windows.Forms.TextBox();
            this.textBoxANLIDANJIA = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxANLIRIQI = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.案例位置DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.楼层DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.总层DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.结构DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.设计用途DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.面积DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.单价DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.调查日期DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableAnliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qSGJDataSet = new WindowsFormsApplication5.QSGJDataSet();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxYONGTU = new System.Windows.Forms.ComboBox();
            this.comboBoxJIEGOU = new System.Windows.Forms.ComboBox();
            this.table_AnliTableAdapter = new WindowsFormsApplication5.QSGJDataSetTableAdapters.Table_AnliTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableAnliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qSGJDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(733, 493);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 36);
            this.button3.TabIndex = 5;
            this.button3.Text = "导出到EXCEL";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(631, 494);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 35);
            this.button4.TabIndex = 6;
            this.button4.Text = "添加案例";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 510);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "案例位置";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 546);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "楼层";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 548);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "总层";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 550);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "结构";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(659, 546);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "单价";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(552, 546);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "面积";
            // 
            // textBoxANWEIZHI
            // 
            this.textBoxANWEIZHI.Location = new System.Drawing.Point(80, 507);
            this.textBoxANWEIZHI.Name = "textBoxANWEIZHI";
            this.textBoxANWEIZHI.Size = new System.Drawing.Size(290, 21);
            this.textBoxANWEIZHI.TabIndex = 13;
            // 
            // textBoxANLILOUCENG
            // 
            this.textBoxANLILOUCENG.Location = new System.Drawing.Point(71, 543);
            this.textBoxANLILOUCENG.Name = "textBoxANLILOUCENG";
            this.textBoxANLILOUCENG.Size = new System.Drawing.Size(46, 21);
            this.textBoxANLILOUCENG.TabIndex = 14;
            // 
            // textBoxANLIZONGCENG
            // 
            this.textBoxANLIZONGCENG.Location = new System.Drawing.Point(170, 545);
            this.textBoxANLIZONGCENG.Name = "textBoxANLIZONGCENG";
            this.textBoxANLIZONGCENG.Size = new System.Drawing.Size(42, 21);
            this.textBoxANLIZONGCENG.TabIndex = 15;
            // 
            // textBoxANLIMIANJI
            // 
            this.textBoxANLIMIANJI.Location = new System.Drawing.Point(596, 543);
            this.textBoxANLIMIANJI.Name = "textBoxANLIMIANJI";
            this.textBoxANLIMIANJI.Size = new System.Drawing.Size(57, 21);
            this.textBoxANLIMIANJI.TabIndex = 17;
            // 
            // textBoxANLIDANJIA
            // 
            this.textBoxANLIDANJIA.Location = new System.Drawing.Point(705, 543);
            this.textBoxANLIDANJIA.Name = "textBoxANLIDANJIA";
            this.textBoxANLIDANJIA.Size = new System.Drawing.Size(100, 21);
            this.textBoxANLIDANJIA.TabIndex = 18;
            this.textBoxANLIDANJIA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox6_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(400, 510);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 19;
            this.label7.Text = "调查日期";
            // 
            // textBoxANLIRIQI
            // 
            this.textBoxANLIRIQI.Location = new System.Drawing.Point(468, 507);
            this.textBoxANLIRIQI.Name = "textBoxANLIRIQI";
            this.textBoxANLIRIQI.Size = new System.Drawing.Size(146, 21);
            this.textBoxANLIRIQI.TabIndex = 20;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.案例位置DataGridViewTextBoxColumn,
            this.楼层DataGridViewTextBoxColumn,
            this.总层DataGridViewTextBoxColumn,
            this.结构DataGridViewTextBoxColumn,
            this.设计用途DataGridViewTextBoxColumn,
            this.面积DataGridViewTextBoxColumn,
            this.单价DataGridViewTextBoxColumn,
            this.调查日期DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tableAnliBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(863, 421);
            this.dataGridView1.TabIndex = 21;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 60;
            // 
            // 案例位置DataGridViewTextBoxColumn
            // 
            this.案例位置DataGridViewTextBoxColumn.DataPropertyName = "案例位置";
            this.案例位置DataGridViewTextBoxColumn.HeaderText = "案例位置";
            this.案例位置DataGridViewTextBoxColumn.Name = "案例位置DataGridViewTextBoxColumn";
            this.案例位置DataGridViewTextBoxColumn.ReadOnly = true;
            this.案例位置DataGridViewTextBoxColumn.Width = 200;
            // 
            // 楼层DataGridViewTextBoxColumn
            // 
            this.楼层DataGridViewTextBoxColumn.DataPropertyName = "楼层";
            this.楼层DataGridViewTextBoxColumn.HeaderText = "楼层";
            this.楼层DataGridViewTextBoxColumn.Name = "楼层DataGridViewTextBoxColumn";
            this.楼层DataGridViewTextBoxColumn.ReadOnly = true;
            this.楼层DataGridViewTextBoxColumn.Width = 60;
            // 
            // 总层DataGridViewTextBoxColumn
            // 
            this.总层DataGridViewTextBoxColumn.DataPropertyName = "总层";
            this.总层DataGridViewTextBoxColumn.HeaderText = "总层";
            this.总层DataGridViewTextBoxColumn.Name = "总层DataGridViewTextBoxColumn";
            this.总层DataGridViewTextBoxColumn.ReadOnly = true;
            this.总层DataGridViewTextBoxColumn.Width = 60;
            // 
            // 结构DataGridViewTextBoxColumn
            // 
            this.结构DataGridViewTextBoxColumn.DataPropertyName = "结构";
            this.结构DataGridViewTextBoxColumn.HeaderText = "结构";
            this.结构DataGridViewTextBoxColumn.Name = "结构DataGridViewTextBoxColumn";
            this.结构DataGridViewTextBoxColumn.ReadOnly = true;
            this.结构DataGridViewTextBoxColumn.Width = 60;
            // 
            // 设计用途DataGridViewTextBoxColumn
            // 
            this.设计用途DataGridViewTextBoxColumn.DataPropertyName = "设计用途";
            this.设计用途DataGridViewTextBoxColumn.HeaderText = "设计用途";
            this.设计用途DataGridViewTextBoxColumn.Name = "设计用途DataGridViewTextBoxColumn";
            this.设计用途DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 面积DataGridViewTextBoxColumn
            // 
            this.面积DataGridViewTextBoxColumn.DataPropertyName = "面积";
            this.面积DataGridViewTextBoxColumn.HeaderText = "面积";
            this.面积DataGridViewTextBoxColumn.Name = "面积DataGridViewTextBoxColumn";
            this.面积DataGridViewTextBoxColumn.ReadOnly = true;
            this.面积DataGridViewTextBoxColumn.Width = 60;
            // 
            // 单价DataGridViewTextBoxColumn
            // 
            this.单价DataGridViewTextBoxColumn.DataPropertyName = "单价";
            this.单价DataGridViewTextBoxColumn.HeaderText = "单价";
            this.单价DataGridViewTextBoxColumn.Name = "单价DataGridViewTextBoxColumn";
            this.单价DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 调查日期DataGridViewTextBoxColumn
            // 
            this.调查日期DataGridViewTextBoxColumn.DataPropertyName = "调查日期";
            this.调查日期DataGridViewTextBoxColumn.HeaderText = "调查日期";
            this.调查日期DataGridViewTextBoxColumn.Name = "调查日期DataGridViewTextBoxColumn";
            this.调查日期DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tableAnliBindingSource
            // 
            this.tableAnliBindingSource.DataMember = "Table_Anli";
            this.tableAnliBindingSource.DataSource = this.qSGJDataSet;
            // 
            // qSGJDataSet
            // 
            this.qSGJDataSet.DataSetName = "QSGJDataSet";
            this.qSGJDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(395, 550);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 23;
            this.label8.Text = "设计用途";
            // 
            // comboBoxYONGTU
            // 
            this.comboBoxYONGTU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxYONGTU.FormattingEnabled = true;
            this.comboBoxYONGTU.Items.AddRange(new object[] {
            "住宅",
            "商服",
            "工业"});
            this.comboBoxYONGTU.Location = new System.Drawing.Point(454, 546);
            this.comboBoxYONGTU.Name = "comboBoxYONGTU";
            this.comboBoxYONGTU.Size = new System.Drawing.Size(75, 20);
            this.comboBoxYONGTU.TabIndex = 24;
            // 
            // comboBoxJIEGOU
            // 
            this.comboBoxJIEGOU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxJIEGOU.FormattingEnabled = true;
            this.comboBoxJIEGOU.Items.AddRange(new object[] {
            "混合",
            "框架",
            "砖木"});
            this.comboBoxJIEGOU.Location = new System.Drawing.Point(291, 545);
            this.comboBoxJIEGOU.Name = "comboBoxJIEGOU";
            this.comboBoxJIEGOU.Size = new System.Drawing.Size(79, 20);
            this.comboBoxJIEGOU.TabIndex = 25;
            // 
            // table_AnliTableAdapter
            // 
            this.table_AnliTableAdapter.ClearBeforeFill = true;
            // 
            // Anli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 583);
            this.Controls.Add(this.comboBoxJIEGOU);
            this.Controls.Add(this.comboBoxYONGTU);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxANLIRIQI);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxANLIDANJIA);
            this.Controls.Add(this.textBoxANLIMIANJI);
            this.Controls.Add(this.textBoxANLIZONGCENG);
            this.Controls.Add(this.textBoxANLILOUCENG);
            this.Controls.Add(this.textBoxANWEIZHI);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Name = "Anli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "案例编辑";
            this.Load += new System.EventHandler(this.Anli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableAnliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qSGJDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxANWEIZHI;
        private System.Windows.Forms.TextBox textBoxANLILOUCENG;
        private System.Windows.Forms.TextBox textBoxANLIZONGCENG;
        private System.Windows.Forms.TextBox textBoxANLIMIANJI;
        private System.Windows.Forms.TextBox textBoxANLIDANJIA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxANLIRIQI;
        private QSGJDataSet qSGJDataSet;
        private QSGJDataSetTableAdapters.Table_AnliTableAdapter table_AnliTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxYONGTU;
        private System.Windows.Forms.BindingSource tableAnliBindingSource;
        private System.Windows.Forms.ComboBox comboBoxJIEGOU;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 案例位置DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 楼层DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 总层DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 结构DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 设计用途DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 面积DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 单价DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 调查日期DataGridViewTextBoxColumn;

    }
}