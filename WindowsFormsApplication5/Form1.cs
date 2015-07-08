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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //是否已经登录
        
        //登录限制
        private void Form1_Load(object sender, EventArgs e)
        {
            //登录限制
            dengluxianzhi();//
            //读取INI字符串
            Jingtai.loadsql();




            toolStripStatusLabel3.Text = DateTime.Now.Year + "年"
                + DateTime.Now.Month + "月"
                + DateTime.Now.Day + "日";
            Jingtai.RIQI = toolStripStatusLabel3.Text;
        }

        void dengluxianzhi()
        {
            if (Jingtai.DLZT == 1)
            {
                登录ToolStripMenuItem.Enabled = false;
                注销ToolStripMenuItem.Enabled = true;
                项目ToolStripMenuItem.Enabled = true;
                工具ToolStripMenuItem.Enabled = true;
                
                toolStripStatusLabel1.Text = "登录用户：" + Jingtai.DLmingzi;
                toolStripStatusLabelYHLX.Text = "用户级别："+Jingtai.DLjibie.ToString();
                
            }
            else
            {
                登录ToolStripMenuItem.Enabled = true;
                注销ToolStripMenuItem.Enabled = false;
                项目ToolStripMenuItem.Enabled = false;
                工具ToolStripMenuItem.Enabled = false;
               
                toolStripStatusLabel1.Text = "登录用户：" + Jingtai.DLmingzi;
                toolStripStatusLabelYHLX.Text = "用户级别：" + Jingtai.DLjibie.ToString();
            }
        }
        

        //只打开一次
        private bool isExist(string ChildTypeName)
        {
            bool b_result = false;
            foreach (Form frm in MdiChildren)
            {
                if (frm.GetType().Name == ChildTypeName)
                {
                    frm.Activate();
                    b_result = true;
                    break;
                }
            }
            return b_result;
        }

        private void 登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isExist("Denglu"))
            {
                Denglu denglu = new Denglu();
                denglu.MdiParent = this;
                denglu.Show();
                
            }
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isExist("Formhelp"))
            {
                Formhelp formhelp = new Formhelp();
                formhelp.MdiParent = this;
                formhelp.Show();
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        //
        //这是捕捉鼠标滚动事件
        //public void Panel_MouseWheel(object sender, MouseEventArgs e)
        //{
        //    float addsd=0;
        //    if (e.Delta > 0)
        //        addsd -= 0.1f;
        //    else
        //        addsd += 0.1f;
        //    if (addsd >= 3)
        //        addsd = 3;
        //    if (addsd <= 1)
        //        addsd = 1f;
        //    toolStripStatusLabel2.Text = addsd.ToString();
            
        //}

        

        private void 新建估价项目ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (!isExist("Xinjian"))
            //{
            //    Xinjian xinjian = new Xinjian();
            //    xinjian.MdiParent = this;
            //    xinjian.Show();
               
            //}

            Form f = Application.OpenForms["Xinjian"];  //查找是否打开过Form1窗体  
            if (f == null) //没打开过  
            {
                Xinjian xinjian = new Xinjian();
                xinjian.MdiParent = this;
                xinjian.Show();

                


            }
            else
            {
                f.Focus();   //打开过就让其获得焦点  
            }  


        }

        private void 估价案例ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isExist("Anli"))
            {
                Anli anli = new Anli();
                anli.MdiParent = this;
                anli.Show();
            }
                

        }

        private void 参数设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isExist("Shezhi"))
            {
                Shezhi shezhi = new Shezhi();
                shezhi.MdiParent = this;
                shezhi.Show();
            }
        }

        

        private void 注销ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Jingtai.DLZT = 0;
            Jingtai.DLuser = "已注销";
            Jingtai.DLmingzi = "已注销";
            Jingtai.DLjibie = 0;
            dengluxianzhi();
            Form[] frmList = this.MdiChildren;
            foreach (Form frm in frmList)
            {
                frm.Close();
            }

            
        }



        private void Form1_Activated(object sender, EventArgs e)
        {
            dengluxianzhi();//激活窗体
        }

       


        private void 用户管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isExist("Yonghu"))
            {
                Yonghu yonghu = new Yonghu();
                yonghu.MdiParent=this;
                yonghu.Show();
                
            }

        }

        private void 交易管理系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isExist("Jiaoyi"))
            {
                Jiaoyi jiaoyi = new Jiaoyi();
                jiaoyi.MdiParent = this;
                jiaoyi.Show();
            }
        }

       

        private void 评估费计算ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["Pinggufei"];  //查找是否打开过Form1窗体  
            if (f == null) //没打开过  
            {
                Pinggufei pinggufei = new Pinggufei();
                pinggufei.MdiParent=this;
                pinggufei.Show();

               



            }
            else
            {
                f.Focus();   //打开过就让其获得焦点  
            }  ////////////////////////
            
           
        }

        private void 注册产品ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isExist("Zhuce"))
            {
                Zhuce zhuce = new Zhuce();
                zhuce.MdiParent = this;
                zhuce.Show();

            }
        }

      

        private void 估价参数调整ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isExist("Canshu"))
            {
                Canshu canshu = new Canshu();
                canshu.MdiParent=this;
                canshu.Show();
            
            }
        }

        private void 查询估价项目ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isExist("Chaxun"))
            {
                Chaxun chaxun = new Chaxun();
                chaxun.MdiParent = this;
                chaxun.Show();
                
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 测试模式ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Jingtai.DLjibie = 9;
            Jingtai.DLZT = 1;
            Jingtai.DLmingzi = "测试用户";
            dengluxianzhi();
        }

        private void 报告生成器ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
