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
    public partial class Shezhi : Form
    {
        //成员变量
        //配置文件存放的名字。


        public Shezhi()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //设置默认值
            textBox1.Text = @"127.0.0.1";
            
            textBox3.Text = @"1433";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //保存配置信息
            
            Jingtai.savesql(textBox1.Text,textBox3.Text,textBox4.Text,textBox2.Text);
            
            
            
        }

        private void Shezhi_Load(object sender, EventArgs e)
        {
            Jingtai.loadsql();
            textBox1.Text = Jingtai.server_ip;
            textBox3.Text = Jingtai.server_port;
            textBox2.Text = Jingtai.server_uid;
            textBox4.Text = Jingtai.server_database;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1_Click(sender,e);
            int jiance = 1;
            try
            {
                System.Data.SqlClient.SqlConnection conn = null;
                conn = new System.Data.SqlClient.SqlConnection(Jingtai.ConnectionString);
                conn.Open();
                conn.Close();
            }
            catch
            {
                
                jiance = 0;
            }
            if (jiance == 0)
            {
                label3.Text = "检测失败";
                pictureBox1.BackColor = Color.Red;
                
            }
            else if (jiance == 1)
            {
                label3.Text = "检测通过";
                pictureBox1.BackColor = Color.Green;
            }
            else
            {
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MySql.Data.MySqlClient.MySqlConnection myconn = null;

            
            myconn = new MySql.Data.MySqlClient.MySqlConnection("Database=qsgj;Data Source=127.0.0.1;User Id=root;Password=;pooling=false;CharSet=utf8;port=3306");

            myconn.Open();
            myconn.Close();
        }

       

       
            
            
         
    }
}
