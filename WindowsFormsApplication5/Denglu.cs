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
    public partial class Denglu : Form
    {
        public Denglu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //首先取得s数据库中的账号和密码保存到变量中
            string name = "默认";
            string pass = null;
            string mingzi = null;
            
            
            //查询数据库
            //先寻找数据库表中含有NAME的表
            //如果有就弹出OK 没有就弹出不ok

            //创链接字符串

           // 已经放到静态类中 string ConnectionString = @"Server=127.0.0.1\SQLEXPRESS,1433;Database=QSGJ;uid=sa;pwd=54605802zz";
            //创建链接
            SqlConnection conn = null;
            conn=new SqlConnection(Jingtai.ConnectionString);
            conn.Open();
            //创建命令对象
            SqlCommand cmd=null;
            //创建语句字符串
            string sql=null;

            string DLyonghu=null;
            DLyonghu = textBoxUSER.Text;
            sql = @"select * from Table_User where 用户名='"+DLyonghu+@"'";

            //创建一个命令对象

            cmd = new SqlCommand(sql,conn);
            
                SqlDataReader reader;
                reader=cmd.ExecuteReader(); //查询服务器
                if (reader.HasRows)
                {
                    reader.Read();
                    

                    int id = reader.GetInt32(0);
                    string DLname = reader.GetString(1);
                        
                    string DLpass = reader.GetString(2);
                    string DLmingzi = reader.GetString(5);
                    int DLjibie = reader.GetInt32(6) ;

                    // string name = reader.GetString(1);
                    //string  gender = reader.GetBoolean(3) == true ? "男" : "女"; //运用了三元表达式
                    // int age = reader.GetInt32(2);

                    name = DLname.ToString() ;
                    pass = DLpass;
                    mingzi = DLmingzi;
                    label7.Text = name;
                    Jingtai.DLjibie = DLjibie;
                    
                    //MessageBox.Show("传递给了PASS,并且里边有内容，");
                }
                else
                {//这是没有找到用户名


                    MessageBox.Show("无此用户");
                    Jingtai.DLZT = 0;
                }

                string boxuser=textBoxUSER.Text;
                int changducha = name.Length - boxuser.Length;

           
                for (int i = 1; i <= changducha; i++)
                {
                    boxuser += " ";

                }
                //textboxuser.Length = 10;
                if (pass == textBoxPASS.Text && name == boxuser)
                {
                    label4.Text = "这里是“与”比较通过";
                    
                    Jingtai.DLZT = 1;
                }
                else
                {
                    label5.Text = "这里是“与”比较不通过";
                    
                    Jingtai.DLZT = 0;
                    label8.Text = "服务器回传字段长度："+name.Length.ToString();
                    label9.Text = "本地字段长度修正后的值："+boxuser.Length.ToString(); 
                }


                if (Jingtai.DLZT == 1)
                {
                    Jingtai.DLZT = 1;
                    Jingtai.DLuser = name;
                    Jingtai.DLmingzi = mingzi;
                    label3.Text = "登录成功";
                    MessageBox.Show("登录成功"+Jingtai.DLuser);
                    button1.Enabled = false;
                    Close();
                    
                }
                else
                {
                    Jingtai.DLZT = 0;
                    Jingtai.DLuser = "无";
                    Jingtai.DLmingzi = "无";
                    label3.Text = "登录失败";
                    MessageBox.Show("登录失败");
                    
                }


            conn.Close();
            
        }

        private void Denglu_Load(object sender, EventArgs e)
        {

        }
    }
}
