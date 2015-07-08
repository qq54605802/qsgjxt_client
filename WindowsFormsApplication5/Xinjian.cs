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
    public partial class Xinjian : Form
    {
        public Xinjian()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Form f = Application.OpenForms["Temp"];  //查找是否打开过Form1窗体  
            if (f == null) //没打开过  
            {
                Temp temp = new Temp();
                temp.MdiParent = this.MdiParent; ;
                temp.Show();

            }
            else
            {
                f.Focus();   //打开过就让其获得焦点  
            }  
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["XuanquAnli"];  //查找是否打开过Form1窗体  
            if (f == null) //没打开过  
            {
                XuanquAnli xuanquanli = new XuanquAnli();
                xuanquanli.MdiParent = this.MdiParent;
                xuanquanli.Show();                
            }
            else
            {
                f.Focus();   //打开过就让其获得焦点  
            }  


            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["Fenpei"];  //查找是否打开过Form1窗体  
            if (f == null) //没打开过  
            {
                Fenpei fenpei = new Fenpei();
                fenpei.MdiParent = this.MdiParent;
                fenpei.Show();
               
            }
            else
            {
                f.Focus();   //打开过就让其获得焦点  
            }  
        }

        private void Xinjian_Activated(object sender, EventArgs e)
        {
            try
            {
                if ((Jingtai.myid != 0 && button4.Enabled == true) || Jingtai.anli_A != 0)
                {


                    
                        //要载入项目数据信息 并且让一些按钮变成灰色
                        button4.Enabled = false;
                        button6.Enabled = false;
                        panel1.Enabled = true;

                        textBoxID.Text = Jingtai.myid.ToString();

                        //通过ID来索引项目，加载进来 
                        //打开数据库
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

                        textBoxNIAN.Text = ds.Tables[0].Rows[0][5].ToString();
                        textBoxBIANHAO.Text = ds.Tables[0].Rows[0][6].ToString();
                        textBoxWEITUOREN.Text = ds.Tables[0].Rows[0][4].ToString();
                        textBoxXINGZHI.Text = ds.Tables[0].Rows[0][2].ToString();
                        textBoxBUMEN.Text = ds.Tables[0].Rows[0][3].ToString();
                        textBoxSHENQINGREN.Text = ds.Tables[0].Rows[0][1].ToString();
                        textBoxBEIZHU.Text = ds.Tables[0].Rows[0][7].ToString();



                        textBoxDIANHUA.Text = ds.Tables[0].Rows[0][9].ToString();
                        textBoxSUOYOUQUAN.Text = ds.Tables[0].Rows[0][10].ToString();
                        textBoxZHENGHAO.Text = ds.Tables[0].Rows[0][11].ToString();
                        textBoxCHANJI.Text = ds.Tables[0].Rows[0][12].ToString();
                        textBoxZUOLUO.Text = ds.Tables[0].Rows[0][13].ToString();
                        textBoxLEIQU.Text = ds.Tables[0].Rows[0][14].ToString();
                        textBox1NIANDAI.Text = ds.Tables[0].Rows[0][15].ToString();
                        textBoxSHEJIYONGTU.Text = ds.Tables[0].Rows[0][16].ToString();
                        textBoxGONGJIAOCHE.Text = ds.Tables[0].Rows[0][17].ToString();
                        textBoxJIANZHUMIANJI.Text = ds.Tables[0].Rows[0][18].ToString();
                        textBoxBEI.Text = ds.Tables[0].Rows[0][19].ToString();
                        textBoxNAN.Text = ds.Tables[0].Rows[0][20].ToString();
                        textBoxXI.Text = ds.Tables[0].Rows[0][21].ToString();
                        textBoxDONG.Text = ds.Tables[0].Rows[0][22].ToString();
                        textBox1TUDIMIANJI.Text = ds.Tables[0].Rows[0][23].ToString();
                        textBoxTUDIYONGTU.Text = ds.Tables[0].Rows[0][24].ToString();
                        textBoxQUDEFANGSHI.Text = ds.Tables[0].Rows[0][25].ToString();
                        textBoxTUDIJIBIE.Text = ds.Tables[0].Rows[0][26].ToString();
                        textBoxMIAOSHUFANG.Text = ds.Tables[0].Rows[0][27].ToString();
                        textBoxMIAOSHUQUAN.Text = ds.Tables[0].Rows[0][28].ToString();
                        textBoxMIAOSHUTUDI.Text = ds.Tables[0].Rows[0][29].ToString();

                        textBoxANLIIDA.Text = ds.Tables[0].Rows[0][31].ToString();
                        textBoxANLIIDB.Text = ds.Tables[0].Rows[0][32].ToString();
                        textBoxANLIIDC.Text = ds.Tables[0].Rows[0][33].ToString();


                        //更新到数据库中
                        //ds.Tables[0].Rows[0][7]="更新到服务器的测试";
                        //SqlCommandBuilder baseInsertCommand = new SqlCommandBuilder(dataAdpt);
                        //dataAdpt.Update(ds,"Table_Ku");

                        //更新到数据库中




                        //开始导入案例的数据库


                        if (textBoxANLIIDA.Text != "")
                        {

                            searchStr = "select * from Table_Anli where id='" + textBoxANLIIDA.Text + "'";
                            DataSet ds_anliA = new DataSet();

                            SqlDataAdapter data_AnliA_Adpt = new SqlDataAdapter(searchStr, sqlCont);  //执行查询

                            data_AnliA_Adpt.Fill(ds_anliA, "Table_Anli");
                            ///////////////////////////

                            searchStr = "select * from Table_Anli where id='" + textBoxANLIIDB.Text + "'";
                            DataSet ds_anliB = new DataSet();

                            SqlDataAdapter data_AnliB_Adpt = new SqlDataAdapter(searchStr, sqlCont);  //执行查询

                            data_AnliB_Adpt.Fill(ds_anliB, "Table_Anli");
                            ///////////////////////////////

                            searchStr = "select * from Table_Anli where id='" + textBoxANLIIDC.Text + "'";
                            DataSet ds_anliC = new DataSet();

                            SqlDataAdapter data_AnliC_Adpt = new SqlDataAdapter(searchStr, sqlCont);  //执行查询

                            data_AnliC_Adpt.Fill(ds_anliC, "Table_Anli");

                            ///////////案例A//////
                            textBoxWEIZHIA.Text = ds_anliA.Tables[0].Rows[0][1].ToString();
                            textBoxANLIJIAGEA.Text = ds_anliA.Tables[0].Rows[0][7].ToString();
                            textBoxSUOZAICENGA.Text = ds_anliA.Tables[0].Rows[0][2].ToString();
                            textBoxZONGCENGA.Text = ds_anliA.Tables[0].Rows[0][3].ToString();


                            //案例B
                            textBoxWEIZHIB.Text = ds_anliB.Tables[0].Rows[0][1].ToString();
                            textBoxANLIJIAGEB.Text = ds_anliB.Tables[0].Rows[0][7].ToString();
                            textBoxSUOZAICENGB.Text = ds_anliB.Tables[0].Rows[0][2].ToString();
                            textBoxZONGCENGB.Text = ds_anliB.Tables[0].Rows[0][3].ToString();

                            //案例C
                            textBoxWEIZHIC.Text = ds_anliC.Tables[0].Rows[0][1].ToString();
                            textBoxANLIJIAGEC.Text = ds_anliC.Tables[0].Rows[0][7].ToString();
                            textBoxSUOZAICENGC.Text = ds_anliC.Tables[0].Rows[0][2].ToString();
                            textBoxZONGCENGC.Text = ds_anliC.Tables[0].Rows[0][3].ToString();


                        }
                        else { }

                    Jingtai.anli_A = 0;//防止重复读取数据库

 

                    sqlCont.Close();


                }
                else
                { }


            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.Source);
                MessageBox.Show(ex.ToString());
            }
        }
        

        private void Xinjian_Load(object sender, EventArgs e)
        {
            Jingtai.myid = 0;//重置ID
            Jingtai.anli_A = 0;
            Jingtai.anli_B = 0;
            Jingtai.anli_C = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["Dakaixiangmu"];  //查找是否打开过Form1窗体  
            if (f == null) //没打开过  
            {
                Dakaixiangmu dakaixiangmu= new Dakaixiangmu();
                dakaixiangmu.MdiParent = this.MdiParent;
                dakaixiangmu.Show();
                
                
            }
            else
            {
                f.Focus();   //打开过就让其获得焦点  
            }  
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        //保存项目信息
        private void button1_Click_1(object sender, EventArgs e)
        {//下面的东西需要修改

                

                //通过ID来索引项目，加载进来 
                //打开数据库
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

                //textBoxNIAN.Text = ds.Tables[0].Rows[0][5].ToString();
                //textBoxBIANHAO.Text = ds.Tables[0].Rows[0][6].ToString();
                //textBoxWEITUOREN.Text = ds.Tables[0].Rows[0][4].ToString();
                //textBoxXINGZHI.Text = ds.Tables[0].Rows[0][2].ToString();
                //textBoxBUMEN.Text = ds.Tables[0].Rows[0][3].ToString();
                //textBoxSHENQINGREN.Text = ds.Tables[0].Rows[0][1].ToString();
                //textBoxBEIZHU.Text = ds.Tables[0].Rows[0][7].ToString();

                //更新到数据库中 基础信息，
                ds.Tables[0].Rows[0][9] = textBoxDIANHUA.Text;
                ds.Tables[0].Rows[0][10] = textBoxSUOYOUQUAN.Text;
                ds.Tables[0].Rows[0][11] = textBoxZHENGHAO.Text;
                ds.Tables[0].Rows[0][12] = textBoxCHANJI.Text;
                ds.Tables[0].Rows[0][13] = textBoxZUOLUO.Text;
                ds.Tables[0].Rows[0][14] = textBoxLEIQU.Text;
                ds.Tables[0].Rows[0][15] = textBox1NIANDAI.Text;
                ds.Tables[0].Rows[0][16] = textBoxSHEJIYONGTU.Text;
                ds.Tables[0].Rows[0][17] = textBoxGONGJIAOCHE.Text;
                ds.Tables[0].Rows[0][18] = textBoxJIANZHUMIANJI.Text;
                ds.Tables[0].Rows[0][19] = textBoxBEI.Text;
                ds.Tables[0].Rows[0][20] = textBoxNAN.Text;
                ds.Tables[0].Rows[0][21] = textBoxXI.Text;
                ds.Tables[0].Rows[0][22] = textBoxDONG.Text;
                ds.Tables[0].Rows[0][23] = textBox1TUDIMIANJI.Text;
                ds.Tables[0].Rows[0][24] = textBoxTUDIYONGTU.Text;
                ds.Tables[0].Rows[0][25] = textBoxQUDEFANGSHI.Text;
                ds.Tables[0].Rows[0][26] = textBoxTUDIJIBIE.Text;
                ds.Tables[0].Rows[0][27] = textBoxMIAOSHUFANG.Text;
                ds.Tables[0].Rows[0][28] = textBoxMIAOSHUQUAN.Text;
                ds.Tables[0].Rows[0][29] = textBoxMIAOSHUTUDI.Text;
            //再单独更新进去委托人和备注
                ds.Tables[0].Rows[0][4] = textBoxWEITUOREN.Text;
                ds.Tables[0].Rows[0][7] = textBoxBEIZHU.Text;

            //保存案例ID

                ds.Tables[0].Rows[0][31] = textBoxANLIIDA.Text;
                ds.Tables[0].Rows[0][32] = textBoxANLIIDB.Text;
                ds.Tables[0].Rows[0][33] = textBoxANLIIDC.Text;
           
                SqlCommandBuilder baseInsertCommand = new SqlCommandBuilder(dataAdpt);
                dataAdpt.Update(ds,"Table_Ku");

            
            
                //更新到数据库中
                sqlCont.Close();




            
        }
    }
}
