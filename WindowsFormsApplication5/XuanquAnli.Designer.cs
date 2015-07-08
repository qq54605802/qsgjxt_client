namespace WindowsFormsApplication5
{
    partial class XuanquAnli
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.案例位置 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.楼层 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.总层 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.结构 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.设计用途 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.面积 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.单价 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.调查日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table_AnliTableAdapter = new WindowsFormsApplication5.QSGJDataSetTableAdapters.Table_AnliTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableAnliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qSGJDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
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
            this.dataGridView1.Location = new System.Drawing.Point(117, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(739, 383);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 40;
            // 
            // 案例位置DataGridViewTextBoxColumn
            // 
            this.案例位置DataGridViewTextBoxColumn.DataPropertyName = "案例位置";
            this.案例位置DataGridViewTextBoxColumn.HeaderText = "案例位置";
            this.案例位置DataGridViewTextBoxColumn.Name = "案例位置DataGridViewTextBoxColumn";
            this.案例位置DataGridViewTextBoxColumn.ReadOnly = true;
            this.案例位置DataGridViewTextBoxColumn.Width = 150;
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
            this.设计用途DataGridViewTextBoxColumn.Width = 80;
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
            this.单价DataGridViewTextBoxColumn.Width = 60;
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
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 491);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(58, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "移除";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 437);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(58, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "移除";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 464);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(58, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "移除";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.案例位置,
            this.楼层,
            this.总层,
            this.结构,
            this.设计用途,
            this.面积,
            this.单价,
            this.调查日期});
            this.dataGridView2.Location = new System.Drawing.Point(117, 418);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(739, 106);
            this.dataGridView2.TabIndex = 12;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 40;
            // 
            // 案例位置
            // 
            this.案例位置.HeaderText = "案例位置";
            this.案例位置.Name = "案例位置";
            this.案例位置.ReadOnly = true;
            this.案例位置.Width = 150;
            // 
            // 楼层
            // 
            this.楼层.HeaderText = "楼层";
            this.楼层.Name = "楼层";
            this.楼层.ReadOnly = true;
            this.楼层.Width = 60;
            // 
            // 总层
            // 
            this.总层.HeaderText = "总层";
            this.总层.Name = "总层";
            this.总层.ReadOnly = true;
            this.总层.Width = 60;
            // 
            // 结构
            // 
            this.结构.HeaderText = "结构";
            this.结构.Name = "结构";
            this.结构.ReadOnly = true;
            this.结构.Width = 60;
            // 
            // 设计用途
            // 
            this.设计用途.HeaderText = "设计用途";
            this.设计用途.Name = "设计用途";
            this.设计用途.ReadOnly = true;
            this.设计用途.Width = 80;
            // 
            // 面积
            // 
            this.面积.HeaderText = "面积";
            this.面积.Name = "面积";
            this.面积.ReadOnly = true;
            this.面积.Width = 60;
            // 
            // 单价
            // 
            this.单价.HeaderText = "单价";
            this.单价.Name = "单价";
            this.单价.ReadOnly = true;
            this.单价.Width = 60;
            // 
            // 调查日期
            // 
            this.调查日期.HeaderText = "调查日期";
            this.调查日期.Name = "调查日期";
            this.调查日期.ReadOnly = true;
            // 
            // table_AnliTableAdapter
            // 
            this.table_AnliTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 498);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "案例C";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 471);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "案例B";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 444);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "案例A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(74, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 228);
            this.label1.TabIndex = 20;
            this.label1.Text = "在\r\n选\r\n择\r\n的\r\n案\r\n例\r\n双\r\n击\r\n鼠\r\n标\r\n选\r\n中";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(862, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 106);
            this.button1.TabIndex = 21;
            this.button1.Text = "应用所选案例";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(875, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 52);
            this.button2.TabIndex = 22;
            this.button2.Text = "查询";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(875, 226);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 29);
            this.textBox1.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(871, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "关键字";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(891, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 25;
            this.label3.Text = "label3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(891, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 26;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(891, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 27;
            this.label8.Text = "label8";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(900, 146);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 28;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // XuanquAnli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 551);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Name = "XuanquAnli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "XuanquAnli";
            this.Load += new System.EventHandler(this.XuanquAnli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableAnliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qSGJDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private QSGJDataSet qSGJDataSet;
        private System.Windows.Forms.BindingSource tableAnliBindingSource;
        private QSGJDataSetTableAdapters.Table_AnliTableAdapter table_AnliTableAdapter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 案例位置DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 楼层DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 总层DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 结构DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 设计用途DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 面积DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 单价DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 调查日期DataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn 案例位置;
        private System.Windows.Forms.DataGridViewTextBoxColumn 楼层;
        private System.Windows.Forms.DataGridViewTextBoxColumn 总层;
        private System.Windows.Forms.DataGridViewTextBoxColumn 结构;
        private System.Windows.Forms.DataGridViewTextBoxColumn 设计用途;
        private System.Windows.Forms.DataGridViewTextBoxColumn 面积;
        private System.Windows.Forms.DataGridViewTextBoxColumn 单价;
        private System.Windows.Forms.DataGridViewTextBoxColumn 调查日期;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button6;
    }
}