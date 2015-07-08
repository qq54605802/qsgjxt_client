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
    public partial class Jiaoyi : Form
    {
        public Jiaoyi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["Buchongfangyuan"];  //查找是否打开过Form1窗体  
            if (f == null) //没打开过  
            {
                Buchongfangyuan buchongfangyuan = new Buchongfangyuan();
                buchongfangyuan.MdiParent = this.MdiParent;
                buchongfangyuan.Show();
                  
            }
            else
            {
                f.Focus();   //打开过就让其获得焦点  
            }  


            
        }
    }
}
