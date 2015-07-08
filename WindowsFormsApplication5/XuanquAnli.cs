using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication5
{
    public partial class XuanquAnli : Form
    {
        public XuanquAnli()
        {
            InitializeComponent();
        }

        private void XuanquAnli_Load(object sender, EventArgs e)
        {
            Jingtai.anli_A = 0;
            Jingtai.anli_B = 0;
            Jingtai.anli_C = 0;
           
            table_AnliTableAdapter.Connection.ConnectionString = Jingtai.ConnectionString;
            // TODO: 这行代码将数据加载到表“qSGJDataSet.Table_Anli”中。您可以根据需要移动或删除它。
            this.table_AnliTableAdapter.Fill(this.qSGJDataSet.Table_Anli);

           

            dataGridView2.Rows.Add(3);
            dataGridView2.CurrentCell = null;
            

        }

       

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            //这是获取双击了第几行第几列的代码
            //textBox1.Text = dataGridView1.Columns[e.ColumnIndex].Index.ToString(); ;
           // textBox1.Text = dataGridView1.Rows[e.RowIndex].Index.ToString();
            int xuanzhong = 0;
            xuanzhong = int.Parse( dataGridView1[0, e.RowIndex].Value.ToString());//获取选中行的ID
            Jingtai.addAnli(xuanzhong);
            

            //dataGridView2.Rows[1].Cells[0].Value = dataGridView1.Rows[1].Cells[0].Value;

            //dataGridView2.Rows[0].Cells[0].Value = Jingtai.anli_A;
            //dataGridView2.Rows[1].Cells[0].Value = Jingtai.anli_B;
            //dataGridView2.Rows[2].Cells[0].Value = Jingtai.anli_C;

            if (Jingtai.anli_X != 9)
            {
                for (int i = 0; i < 9; i++)
                {
                    dataGridView2[i, Jingtai.anli_X - 1].Value = dataGridView1[i, e.RowIndex].Value;
                    
                }
            }
             
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Jingtai.anli_A = 0;
            

            for (int i = 0; i < 9; i++)
            {
                dataGridView2[i, 0].Value = null;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Jingtai.anli_B = 0;
            
            for (int i = 0; i < 9; i++)
            {
                dataGridView2[i, 1].Value = null;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Jingtai.anli_C = 0;
            
            for (int i = 0; i < 9; i++)
            {
                dataGridView2[i, 2].Value = null;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ////先清空view1
            ////获取VIEW的行数
            //int view1hang=dataGridView1.RowCount;

            //for(int j=0;j<view1hang;j++)
            //{
            //    for (int i = 0; i < 9; i++)
            //    {
            //        dataGridView1[i, j].Value = null;
            //    }
            //}

            //试试解除绑定
            dataGridView1.DataSource = null;
            //OK解除了就清空了没问题
            //查询数据库操作



            SqlConnection sqlCont = new SqlConnection(Jingtai.ConnectionString); //创建数据库连接
            if (sqlCont.State == ConnectionState.Open)         //检查连接状态
            {
                sqlCont.Close();
            }
            sqlCont.Open();   //打开数据库连接
            String searchStr = "select * from Table_Anli where 案例位置 like '%" + textBox1.Text + "%'";
            //返回查询结果
            DataSet ds = new DataSet();
            SqlDataAdapter dataAdpt = new SqlDataAdapter(searchStr, sqlCont);  //执行查询
            
            dataAdpt.Fill(ds);//填充完毕
            dataGridView1.Rows.Clear();  //清空原有datagridview列表

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                //dataGridView1.Rows.Add(i+1 , ds.Tables[0].Rows[i][0], ds.Tables[0].Rows[i][1]);
               // dataGridView1.Rows.Add();
                dataGridView1.Rows.Add(ds.Tables[0].Rows[i][0],
                                      ds.Tables[0].Rows[i][1],
                                      ds.Tables[0].Rows[i][2],
                                      ds.Tables[0].Rows[i][3],
                                      ds.Tables[0].Rows[i][4],
                                      ds.Tables[0].Rows[i][5],
                                      ds.Tables[0].Rows[i][6],
                                      ds.Tables[0].Rows[i][7],
                                      ds.Tables[0].Rows[i][8]);
            }

            
            sqlCont.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection sqlCont = new SqlConnection(Jingtai.ConnectionString); //创建数据库连接
            if (sqlCont.State == ConnectionState.Open)         //检查连接状态
            {
                sqlCont.Close();
            }
            sqlCont.Open();   //打开数据库连接
            String searchStr = "select * from Table_Ku where id='" + Jingtai.myid + "'";
            DataSet ds = new DataSet();
            SqlDataAdapter dataAdpt = new SqlDataAdapter(searchStr, sqlCont);  //执行查询

            dataAdpt.Fill(ds, "Table_Ku");//填充完毕

            ds.Tables[0].Rows[0][31] = Jingtai.anli_A;
            ds.Tables[0].Rows[0][32] = Jingtai.anli_B;
            ds.Tables[0].Rows[0][33] = Jingtai.anli_C;



            SqlCommandBuilder baseInsertCommand = new SqlCommandBuilder(dataAdpt);
            dataAdpt.Update(ds, "Table_Ku");

            //更新到数据库中
            sqlCont.Close();

            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            


        }

       
      
       
    }
}
