using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Chaxun : Form
    {
        public Chaxun()
        {
            InitializeComponent();
        }

        private void Chaxun_Load(object sender, EventArgs e)
        {
            table_KuTableAdapter.Connection.ConnectionString = Jingtai.ConnectionString;
            // TODO: 这行代码将数据加载到表“qSGJDataSet.Table_Ku”中。您可以根据需要移动或删除它。
            this.table_KuTableAdapter.Fill(this.qSGJDataSet.Table_Ku);

        }
    }
}
