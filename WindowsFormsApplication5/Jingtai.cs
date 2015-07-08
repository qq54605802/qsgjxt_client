using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication5
{
    static class Jingtai
    {
        
        static public int myid = 0; //报告ID




        //声明登录状态的参数
        static public int DLZT = 0;//登录状态变量    测试模式用
        static public string DLuser = "无";//登录用户
        static public string DLmingzi = "无";//登录名
        static public int DLjibie = 0;//完成后 这个级别换成0
        static public string RIQI = null;//声明一个日期变量


        
        



        //数据库连接字符串声明和添加默认参数        
        static public string server_ip = "qds114812430.my3w.com";
        static public string server_port="1433";
        static public string server_database = "qds114812430_db";
        static public string server_uid = "qds114812430";
        static public string server_pwd = "15944305683zz";

        static public string ConnectionString = "Server="+ server_ip+","+server_port+
                                                ";Database="+server_database+
                                                ";uid="+server_uid+
                                                ";pwd="+server_pwd;
        

        //////////////////////////////数据库参数声明结束/////////////////////////////////////

        /// <summary>
        /// 该方法没有返回值
        /// 该方法将jingtai类中开放的server_ip,server_port,server_database,server_uid,server_pwd
        /// 这些参数用算法组合成SQL字符串
        /// 保存在jingtai的参数 ConnectionString中
        /// 作用是刷新SQL字符串
        /// </summary>
        static public void shuaxin_ConnectionString()
        {
            ConnectionString = "Server=" + server_ip + "," + server_port +
                                               ";Database=" + server_database +
                                               ";uid=" + server_uid +
                                               ";pwd=" + server_pwd;

        }

        


        /// <summary>
        /// 该方法是写入INI的方法
        /// </summary>
        /// <param name="section">ini的段落</param>
        /// <param name="key">INI的关键字</param>
        /// <param name="val">INI关键字的值</param>
        /// <param name="filePath">INI路径和文件名</param>
        /// <returns></returns>
        [System.Runtime.InteropServices.DllImport("kernel32")]
        public static extern long WritePrivateProfileString(string
        section,
        string key, string val, string filePath);

       

        /// <summary>
        /// 该方法用一下参数返回一个数值
        /// </summary>
        /// <param name="section">section：NI文件中的段落名称</param>
        /// <param name="key">key：INI文件中的关键字</param>
        /// <param name="def">def：无法读取时候时候的缺省数值</param>
        /// <param name="retVal">retVal：读取数值；</param>
        /// <param name="size">size：数值的大小</param>
        /// <param name="filePath">filePath：INI文件的完整路径和名称</param>
        /// <returns></returns>
        [System.Runtime.InteropServices.DllImport("kernel32")]
        public static extern int GetPrivateProfileString(string section,
        string key, string def, StringBuilder retVal,
        int size, string filePath);
        //
        /////////////////////////////////////INI方法声明到此结束/////////////////


        /// <summary>
        /// 该方法无返回值，该方法提取config.ini中的数据server,ip和server,port
        /// 将这两个值保存到jingtai类中的 变量server_ip和server_port中
        /// 并且刷新SQL字符串
        /// </summary>
        public static void loadsql(){
            string FileName = System.Windows.Forms.Application.StartupPath + @"\config.ini";
            StringBuilder temp = new StringBuilder(1023);
                      
            Jingtai.GetPrivateProfileString("server", "ip", "读取失败", temp, 255, FileName);
            server_ip = temp.ToString();
            
            Jingtai.GetPrivateProfileString("server", "port", "读取失败", temp, 255, FileName);
            server_port = temp.ToString();

            Jingtai.GetPrivateProfileString("server", "database", "读取失败", temp, 255, FileName);
            server_database = temp.ToString();

            Jingtai.GetPrivateProfileString("server", "uid", "读取失败", temp, 255, FileName);
            server_uid = temp.ToString();

            


            //读取的时候直接就应用
            shuaxin_ConnectionString();//刷新字符串


        }

        /// <summary>
        /// 该方法没有返回值，接收两个参数，一个是IP，一个是端口，该方法将参数传递给jingtai里的IP和端口，
        /// 并且保存在config.ini中，并且刷新程序的SQL字符串
        /// </summary>
        /// <param name="ip">保存的服务器地址</param>
        /// <param name="port">保存的服务器端口</param>
        public static void savesql(string ip,string port,string database,string uid)
        {
            string FileName = System.Windows.Forms.Application.StartupPath + @"\config.ini";

            //保存到配置
            Jingtai.WritePrivateProfileString("server", "ip", ip, FileName);
            Jingtai.WritePrivateProfileString("server", "port", port, FileName);
            Jingtai.WritePrivateProfileString("server", "database", database, FileName);
            Jingtai.WritePrivateProfileString("server", "uid", uid, FileName);
            
            //保存到参数
             Jingtai.server_ip = ip;
             Jingtai.server_port = port;
             Jingtai.server_database = database;
             Jingtai.server_uid=uid;
             Jingtai.shuaxin_ConnectionString();
            
        }


        //设计一个案例容器,没有返回值，但是会将static参数案例ABC进行改变
        
            public static int anli_A = 0;
            public static int anli_B = 0;
            public static int anli_C = 0;
            public static int anli_X = 9;
            public static void addAnli(int id)
            {
                if (anli_A == 0)
                {
                    anli_A = id;
                    anli_X = 1;
                }
                else if (anli_B==0&&id!=anli_A)
                {
                    anli_B=id;
                    anli_X = 2;
                }
                else if (anli_C == 0&&id!=anli_A&&id!=anli_B)
                {
                    anli_C = id;
                    anli_X = 3;
                }
                else if (id == anli_A || id == anli_B || id == anli_C)
                {
                    System.Windows.Forms.MessageBox.Show("每个案例只可以选择一次");
                    anli_X = 9;

                }
                else
                { 
                    System.Windows.Forms.MessageBox.Show("只能选择三个案例");
                    anli_X = 9;
                }

            }
       
        
    }

}
