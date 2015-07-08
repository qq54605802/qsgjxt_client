namespace WindowsFormsApplication5
{
    partial class Chaxun
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.qSGJDataSet = new WindowsFormsApplication5.QSGJDataSet();
            this.tableKuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_KuTableAdapter = new WindowsFormsApplication5.QSGJDataSetTableAdapters.Table_KuTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.报告编号申请人DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.报告性质DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.相关部门DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.委托人DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.报告年份DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.报告编号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.备注DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.编号申请时间DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.房屋编号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.房屋坐落DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.规划用途DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.建筑面积DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qSGJDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableKuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.报告编号申请人DataGridViewTextBoxColumn,
            this.报告性质DataGridViewTextBoxColumn,
            this.相关部门DataGridViewTextBoxColumn,
            this.委托人DataGridViewTextBoxColumn,
            this.报告年份DataGridViewTextBoxColumn,
            this.报告编号DataGridViewTextBoxColumn,
            this.备注DataGridViewTextBoxColumn,
            this.编号申请时间DataGridViewTextBoxColumn,
            this.房屋编号DataGridViewTextBoxColumn,
            this.房屋坐落DataGridViewTextBoxColumn,
            this.规划用途DataGridViewTextBoxColumn,
            this.建筑面积DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tableKuBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(612, 385);
            this.dataGridView1.TabIndex = 0;
            // 
            // qSGJDataSet
            // 
            this.qSGJDataSet.DataSetName = "QSGJDataSet";
            this.qSGJDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableKuBindingSource
            // 
            this.tableKuBindingSource.DataMember = "Table_Ku";
            this.tableKuBindingSource.DataSource = this.qSGJDataSet;
            // 
            // table_KuTableAdapter
            // 
            this.table_KuTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 报告编号申请人DataGridViewTextBoxColumn
            // 
            this.报告编号申请人DataGridViewTextBoxColumn.DataPropertyName = "报告编号申请人";
            this.报告编号申请人DataGridViewTextBoxColumn.HeaderText = "报告编号申请人";
            this.报告编号申请人DataGridViewTextBoxColumn.Name = "报告编号申请人DataGridViewTextBoxColumn";
            this.报告编号申请人DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 报告性质DataGridViewTextBoxColumn
            // 
            this.报告性质DataGridViewTextBoxColumn.DataPropertyName = "报告性质";
            this.报告性质DataGridViewTextBoxColumn.HeaderText = "报告性质";
            this.报告性质DataGridViewTextBoxColumn.Name = "报告性质DataGridViewTextBoxColumn";
            this.报告性质DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 相关部门DataGridViewTextBoxColumn
            // 
            this.相关部门DataGridViewTextBoxColumn.DataPropertyName = "相关部门";
            this.相关部门DataGridViewTextBoxColumn.HeaderText = "相关部门";
            this.相关部门DataGridViewTextBoxColumn.Name = "相关部门DataGridViewTextBoxColumn";
            this.相关部门DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 委托人DataGridViewTextBoxColumn
            // 
            this.委托人DataGridViewTextBoxColumn.DataPropertyName = "委托人";
            this.委托人DataGridViewTextBoxColumn.HeaderText = "委托人";
            this.委托人DataGridViewTextBoxColumn.Name = "委托人DataGridViewTextBoxColumn";
            this.委托人DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 报告年份DataGridViewTextBoxColumn
            // 
            this.报告年份DataGridViewTextBoxColumn.DataPropertyName = "报告年份";
            this.报告年份DataGridViewTextBoxColumn.HeaderText = "报告年份";
            this.报告年份DataGridViewTextBoxColumn.Name = "报告年份DataGridViewTextBoxColumn";
            this.报告年份DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 报告编号DataGridViewTextBoxColumn
            // 
            this.报告编号DataGridViewTextBoxColumn.DataPropertyName = "报告编号";
            this.报告编号DataGridViewTextBoxColumn.HeaderText = "报告编号";
            this.报告编号DataGridViewTextBoxColumn.Name = "报告编号DataGridViewTextBoxColumn";
            this.报告编号DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 备注DataGridViewTextBoxColumn
            // 
            this.备注DataGridViewTextBoxColumn.DataPropertyName = "备注";
            this.备注DataGridViewTextBoxColumn.HeaderText = "备注";
            this.备注DataGridViewTextBoxColumn.Name = "备注DataGridViewTextBoxColumn";
            this.备注DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 编号申请时间DataGridViewTextBoxColumn
            // 
            this.编号申请时间DataGridViewTextBoxColumn.DataPropertyName = "编号申请时间";
            this.编号申请时间DataGridViewTextBoxColumn.HeaderText = "编号申请时间";
            this.编号申请时间DataGridViewTextBoxColumn.Name = "编号申请时间DataGridViewTextBoxColumn";
            this.编号申请时间DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 房屋编号DataGridViewTextBoxColumn
            // 
            this.房屋编号DataGridViewTextBoxColumn.DataPropertyName = "房屋编号";
            this.房屋编号DataGridViewTextBoxColumn.HeaderText = "房屋编号";
            this.房屋编号DataGridViewTextBoxColumn.Name = "房屋编号DataGridViewTextBoxColumn";
            this.房屋编号DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 房屋坐落DataGridViewTextBoxColumn
            // 
            this.房屋坐落DataGridViewTextBoxColumn.DataPropertyName = "房屋坐落";
            this.房屋坐落DataGridViewTextBoxColumn.HeaderText = "房屋坐落";
            this.房屋坐落DataGridViewTextBoxColumn.Name = "房屋坐落DataGridViewTextBoxColumn";
            this.房屋坐落DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 规划用途DataGridViewTextBoxColumn
            // 
            this.规划用途DataGridViewTextBoxColumn.DataPropertyName = "规划用途";
            this.规划用途DataGridViewTextBoxColumn.HeaderText = "规划用途";
            this.规划用途DataGridViewTextBoxColumn.Name = "规划用途DataGridViewTextBoxColumn";
            this.规划用途DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 建筑面积DataGridViewTextBoxColumn
            // 
            this.建筑面积DataGridViewTextBoxColumn.DataPropertyName = "建筑面积";
            this.建筑面积DataGridViewTextBoxColumn.HeaderText = "建筑面积";
            this.建筑面积DataGridViewTextBoxColumn.Name = "建筑面积DataGridViewTextBoxColumn";
            this.建筑面积DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 453);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(257, 439);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 47);
            this.button1.TabIndex = 2;
            this.button1.Text = "模糊查询";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(466, 439);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 47);
            this.button2.TabIndex = 3;
            this.button2.Text = "导出";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 458);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "关键字";
            // 
            // Chaxun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 498);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Chaxun";
            this.Text = "Chaxun";
            this.Load += new System.EventHandler(this.Chaxun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qSGJDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableKuBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private QSGJDataSet qSGJDataSet;
        private System.Windows.Forms.BindingSource tableKuBindingSource;
        private QSGJDataSetTableAdapters.Table_KuTableAdapter table_KuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 报告编号申请人DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 报告性质DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 相关部门DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 委托人DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 报告年份DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 报告编号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 备注DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 编号申请时间DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 房屋编号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 房屋坐落DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 规划用途DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 建筑面积DataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;

    }
}