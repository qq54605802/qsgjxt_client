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
    public partial class Fenpei : Form
    {
        public Fenpei()
        {
            InitializeComponent();
        }

        private void Fenpei_Load(object sender, EventArgs e)
        {
            label2.Text = Jingtai.DLmingzi;
            textBoxNIAN.Text = DateTime.Now.Year.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //必要信息填写验证
            if (textBoxXINGZHI.Text == "" || textBoxBUMEN.Text == "" || textBoxWEITUOREN.Text == "" )
            {
                MessageBox.Show("必要信息填写不完全");
            }
            else
            {
                try
                {


                    //申请估价编号算法，从新写，你妈的
                    SqlConnection conn = new SqlConnection(Jingtai.ConnectionString);
                    conn.Open();//打开链接
                    //创建命令对象
                    SqlCommand cmd = null;
                    //创建语句字符串
                    string sql = null;

                    //到 table_ku 中获取指定年份的报告编号最大的数字和ID
                    int baogaohao;

                    sql = @"select MAX(报告编号) from Table_Ku where 报告年份='" + textBoxNIAN.Text + "'";
                    cmd = new SqlCommand(sql, conn);
                    label3.Text = cmd.ExecuteScalar().ToString();
                    baogaohao = int.Parse(cmd.ExecuteScalar().ToString());
                    //得到最大的报告号
                    baogaohao++;
                    sql = @"INSERT INTO Table_Ku (报告编号申请人,报告性质,相关部门,委托人,报告年份,报告编号,备注,编号申请时间) VALUES ('" + label2.Text +
                    "','" + textBoxXINGZHI.Text +
                    "','" + textBoxBUMEN.Text +
                    "','" + textBoxWEITUOREN.Text +
                    "','" + textBoxNIAN.Text +
                    "','" + baogaohao +
                    "','" + textBoxBEIZHU.Text +
                    "','" + DateTime.Now + "')";
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    sql = @"select id from Table_Ku where 报告年份='" + textBoxNIAN.Text + "' and 报告编号='" + baogaohao.ToString() + "'";
                    cmd = new SqlCommand(sql, conn);
                    int myid = int.Parse(cmd.ExecuteScalar().ToString());
                    Jingtai.myid = myid;



                    conn.Close();//关闭连接
                    Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("fenpeiyichang");
                    
                }
            }
        }
    }
}
