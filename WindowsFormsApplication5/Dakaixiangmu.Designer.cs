namespace WindowsFormsApplication5
{
    partial class Dakaixiangmu
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
            this.委托人电话DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.房屋所有权人DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.房权证号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.产籍号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.房屋坐落DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.房屋类区DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.建筑年代DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.设计用途DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.公交车站DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.建筑面积DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.北DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.南DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.西DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.东DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.土地面积DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.土地用途DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.土地性质DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.取得方式DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.土地级别DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.房屋状况描述DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.房屋所有权证描述DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.土地证描述DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.项目版本DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.委托人电话DataGridViewTextBoxColumn,
            this.房屋所有权人DataGridViewTextBoxColumn,
            this.房权证号DataGridViewTextBoxColumn,
            this.产籍号DataGridViewTextBoxColumn,
            this.房屋坐落DataGridViewTextBoxColumn,
            this.房屋类区DataGridViewTextBoxColumn,
            this.建筑年代DataGridViewTextBoxColumn,
            this.设计用途DataGridViewTextBoxColumn,
            this.公交车站DataGridViewTextBoxColumn,
            this.建筑面积DataGridViewTextBoxColumn,
            this.北DataGridViewTextBoxColumn,
            this.南DataGridViewTextBoxColumn,
            this.西DataGridViewTextBoxColumn,
            this.东DataGridViewTextBoxColumn,
            this.土地面积DataGridViewTextBoxColumn,
            this.土地用途DataGridViewTextBoxColumn,
            this.土地性质DataGridViewTextBoxColumn,
            this.取得方式DataGridViewTextBoxColumn,
            this.土地级别DataGridViewTextBoxColumn,
            this.房屋状况描述DataGridViewTextBoxColumn,
            this.房屋所有权证描述DataGridViewTextBoxColumn,
            this.土地证描述DataGridViewTextBoxColumn,
            this.项目版本DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tableKuBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(663, 392);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
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
            // 委托人电话DataGridViewTextBoxColumn
            // 
            this.委托人电话DataGridViewTextBoxColumn.DataPropertyName = "委托人电话";
            this.委托人电话DataGridViewTextBoxColumn.HeaderText = "委托人电话";
            this.委托人电话DataGridViewTextBoxColumn.Name = "委托人电话DataGridViewTextBoxColumn";
            this.委托人电话DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 房屋所有权人DataGridViewTextBoxColumn
            // 
            this.房屋所有权人DataGridViewTextBoxColumn.DataPropertyName = "房屋所有权人";
            this.房屋所有权人DataGridViewTextBoxColumn.HeaderText = "房屋所有权人";
            this.房屋所有权人DataGridViewTextBoxColumn.Name = "房屋所有权人DataGridViewTextBoxColumn";
            this.房屋所有权人DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 房权证号DataGridViewTextBoxColumn
            // 
            this.房权证号DataGridViewTextBoxColumn.DataPropertyName = "房权证号";
            this.房权证号DataGridViewTextBoxColumn.HeaderText = "房权证号";
            this.房权证号DataGridViewTextBoxColumn.Name = "房权证号DataGridViewTextBoxColumn";
            this.房权证号DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 产籍号DataGridViewTextBoxColumn
            // 
            this.产籍号DataGridViewTextBoxColumn.DataPropertyName = "产籍号";
            this.产籍号DataGridViewTextBoxColumn.HeaderText = "产籍号";
            this.产籍号DataGridViewTextBoxColumn.Name = "产籍号DataGridViewTextBoxColumn";
            this.产籍号DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 房屋坐落DataGridViewTextBoxColumn
            // 
            this.房屋坐落DataGridViewTextBoxColumn.DataPropertyName = "房屋坐落";
            this.房屋坐落DataGridViewTextBoxColumn.HeaderText = "房屋坐落";
            this.房屋坐落DataGridViewTextBoxColumn.Name = "房屋坐落DataGridViewTextBoxColumn";
            this.房屋坐落DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 房屋类区DataGridViewTextBoxColumn
            // 
            this.房屋类区DataGridViewTextBoxColumn.DataPropertyName = "房屋类区";
            this.房屋类区DataGridViewTextBoxColumn.HeaderText = "房屋类区";
            this.房屋类区DataGridViewTextBoxColumn.Name = "房屋类区DataGridViewTextBoxColumn";
            this.房屋类区DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 建筑年代DataGridViewTextBoxColumn
            // 
            this.建筑年代DataGridViewTextBoxColumn.DataPropertyName = "建筑年代";
            this.建筑年代DataGridViewTextBoxColumn.HeaderText = "建筑年代";
            this.建筑年代DataGridViewTextBoxColumn.Name = "建筑年代DataGridViewTextBoxColumn";
            this.建筑年代DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 设计用途DataGridViewTextBoxColumn
            // 
            this.设计用途DataGridViewTextBoxColumn.DataPropertyName = "设计用途";
            this.设计用途DataGridViewTextBoxColumn.HeaderText = "设计用途";
            this.设计用途DataGridViewTextBoxColumn.Name = "设计用途DataGridViewTextBoxColumn";
            this.设计用途DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 公交车站DataGridViewTextBoxColumn
            // 
            this.公交车站DataGridViewTextBoxColumn.DataPropertyName = "公交车站";
            this.公交车站DataGridViewTextBoxColumn.HeaderText = "公交车站";
            this.公交车站DataGridViewTextBoxColumn.Name = "公交车站DataGridViewTextBoxColumn";
            this.公交车站DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 建筑面积DataGridViewTextBoxColumn
            // 
            this.建筑面积DataGridViewTextBoxColumn.DataPropertyName = "建筑面积";
            this.建筑面积DataGridViewTextBoxColumn.HeaderText = "建筑面积";
            this.建筑面积DataGridViewTextBoxColumn.Name = "建筑面积DataGridViewTextBoxColumn";
            this.建筑面积DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 北DataGridViewTextBoxColumn
            // 
            this.北DataGridViewTextBoxColumn.DataPropertyName = "北";
            this.北DataGridViewTextBoxColumn.HeaderText = "北";
            this.北DataGridViewTextBoxColumn.Name = "北DataGridViewTextBoxColumn";
            this.北DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 南DataGridViewTextBoxColumn
            // 
            this.南DataGridViewTextBoxColumn.DataPropertyName = "南";
            this.南DataGridViewTextBoxColumn.HeaderText = "南";
            this.南DataGridViewTextBoxColumn.Name = "南DataGridViewTextBoxColumn";
            this.南DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 西DataGridViewTextBoxColumn
            // 
            this.西DataGridViewTextBoxColumn.DataPropertyName = "西";
            this.西DataGridViewTextBoxColumn.HeaderText = "西";
            this.西DataGridViewTextBoxColumn.Name = "西DataGridViewTextBoxColumn";
            this.西DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 东DataGridViewTextBoxColumn
            // 
            this.东DataGridViewTextBoxColumn.DataPropertyName = "东";
            this.东DataGridViewTextBoxColumn.HeaderText = "东";
            this.东DataGridViewTextBoxColumn.Name = "东DataGridViewTextBoxColumn";
            this.东DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 土地面积DataGridViewTextBoxColumn
            // 
            this.土地面积DataGridViewTextBoxColumn.DataPropertyName = "土地面积";
            this.土地面积DataGridViewTextBoxColumn.HeaderText = "土地面积";
            this.土地面积DataGridViewTextBoxColumn.Name = "土地面积DataGridViewTextBoxColumn";
            this.土地面积DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 土地用途DataGridViewTextBoxColumn
            // 
            this.土地用途DataGridViewTextBoxColumn.DataPropertyName = "土地用途";
            this.土地用途DataGridViewTextBoxColumn.HeaderText = "土地用途";
            this.土地用途DataGridViewTextBoxColumn.Name = "土地用途DataGridViewTextBoxColumn";
            this.土地用途DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 土地性质DataGridViewTextBoxColumn
            // 
            this.土地性质DataGridViewTextBoxColumn.DataPropertyName = "土地性质";
            this.土地性质DataGridViewTextBoxColumn.HeaderText = "土地性质";
            this.土地性质DataGridViewTextBoxColumn.Name = "土地性质DataGridViewTextBoxColumn";
            this.土地性质DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 取得方式DataGridViewTextBoxColumn
            // 
            this.取得方式DataGridViewTextBoxColumn.DataPropertyName = "取得方式";
            this.取得方式DataGridViewTextBoxColumn.HeaderText = "取得方式";
            this.取得方式DataGridViewTextBoxColumn.Name = "取得方式DataGridViewTextBoxColumn";
            this.取得方式DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 土地级别DataGridViewTextBoxColumn
            // 
            this.土地级别DataGridViewTextBoxColumn.DataPropertyName = "土地级别";
            this.土地级别DataGridViewTextBoxColumn.HeaderText = "土地级别";
            this.土地级别DataGridViewTextBoxColumn.Name = "土地级别DataGridViewTextBoxColumn";
            this.土地级别DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 房屋状况描述DataGridViewTextBoxColumn
            // 
            this.房屋状况描述DataGridViewTextBoxColumn.DataPropertyName = "房屋状况描述";
            this.房屋状况描述DataGridViewTextBoxColumn.HeaderText = "房屋状况描述";
            this.房屋状况描述DataGridViewTextBoxColumn.Name = "房屋状况描述DataGridViewTextBoxColumn";
            this.房屋状况描述DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 房屋所有权证描述DataGridViewTextBoxColumn
            // 
            this.房屋所有权证描述DataGridViewTextBoxColumn.DataPropertyName = "房屋所有权证描述";
            this.房屋所有权证描述DataGridViewTextBoxColumn.HeaderText = "房屋所有权证描述";
            this.房屋所有权证描述DataGridViewTextBoxColumn.Name = "房屋所有权证描述DataGridViewTextBoxColumn";
            this.房屋所有权证描述DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 土地证描述DataGridViewTextBoxColumn
            // 
            this.土地证描述DataGridViewTextBoxColumn.DataPropertyName = "土地证描述";
            this.土地证描述DataGridViewTextBoxColumn.HeaderText = "土地证描述";
            this.土地证描述DataGridViewTextBoxColumn.Name = "土地证描述DataGridViewTextBoxColumn";
            this.土地证描述DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 项目版本DataGridViewTextBoxColumn
            // 
            this.项目版本DataGridViewTextBoxColumn.DataPropertyName = "项目版本";
            this.项目版本DataGridViewTextBoxColumn.HeaderText = "项目版本";
            this.项目版本DataGridViewTextBoxColumn.Name = "项目版本DataGridViewTextBoxColumn";
            this.项目版本DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Dakaixiangmu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 507);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Dakaixiangmu";
            this.Text = "Dakaixiangmu";
            this.Load += new System.EventHandler(this.Dakaixiangmu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qSGJDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableKuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        //private System.Windows.Forms.DataGridViewTextBoxColumn 房屋所有权人DataGridViewTextBoxColumn;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn 委托人电话DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 房屋所有权人DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 房权证号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 产籍号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 房屋坐落DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 房屋类区DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 建筑年代DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 设计用途DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 公交车站DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 建筑面积DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 北DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 南DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 西DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 东DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 土地面积DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 土地用途DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 土地性质DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 取得方式DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 土地级别DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 房屋状况描述DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 房屋所有权证描述DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 土地证描述DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 项目版本DataGridViewTextBoxColumn;
    }
}