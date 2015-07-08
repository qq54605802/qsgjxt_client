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
    public partial class Anli : Form
    {
        public Anli()
        {
            InitializeComponent();
        }



        private void Anli_Load(object sender, EventArgs e)
        {
            table_AnliTableAdapter.Connection.ConnectionString = Jingtai.ConnectionString;
            // TODO: 这行代码将数据加载到表“qSGJDataSet.Table_Anli”中。您可以根据需要移动或删除它。
            this.table_AnliTableAdapter.Fill(this.qSGJDataSet.Table_Anli);

            textBoxANLIRIQI.Text = Jingtai.RIQI;

            comboBoxYONGTU.SelectedIndex = 0;
            comboBoxJIEGOU.SelectedIndex = 0;


            

            
        }

        

        

        private void button3_Click(object sender, EventArgs e)
        {
            Export exp = new Export();
            exp.setExcel(dataGridView1, "123");

        }
        public class Export
    {
        //private string fileName;
        /// <summary>
        /// 读入Excel的数据 在DataGridView中显示
        /// </summary>
        /// <param name="dgv">显示内容的DataGridView的名称</param>
        public void setExcel(DataGridView dgv,string name)
        {
            //总可见列数，总可见行数
            int colCount = dgv.Columns.GetColumnCount(DataGridViewElementStates.Visible);
            int rowCount = dgv.Rows.GetRowCount(DataGridViewElementStates.Visible);
            //dataGridView 没有数据提示
            if (dgv.Rows.Count == 0 || rowCount == 0)
            {
                MessageBox.Show("表中没有数据", "提示");
            }
            else
            {
                //选择创建文件的路径
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "excel files(*.xls)|*.xls";
                save.Title = "请选择要导出数据的位置";
                save.FileName = name+DateTime.Now.ToLongDateString();
                if (save.ShowDialog() == DialogResult.OK)
                {
                    string fileName=save.FileName;
                    //MessageBox.Show(save.FileName);
                    // 创建Excel对象
                  //  Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.ApplicationClass();
                    //if (excel == null)
                    //{
                    //    MessageBox.Show("Excel无法启动", "提示");
                    //    return;
                    //}
                    //创建Excel工作薄
                //    Microsoft.Office.Interop.Excel.Workbook excelBook = excel.Workbooks.Add(true);
                //    Microsoft.Office.Interop.Excel.Worksheet excelSheet = (Microsoft.Office.Interop.Excel.Worksheet)excelBook.Worksheets[1];
                    //excel.Application.Workbooks.Add(true);
                    //生成字段名称
                   // int k = 0;
                    //for (int i = 0; i < dgv.ColumnCount; i++)
                    //{
                    //    if (dgv.Columns[i].Visible)  //不导出隐藏的列
                    //    {
                    //        excel.Cells[1, k + 1] = dgv.Columns[i].HeaderText;
                    //        k++;
                    //    }
                    //}
                    //填充数据
                    //for (int i = 0; i < dgv.RowCount; i++)
                    //{
                    //    k = 0;
                    //    for (int j = 0; j < dgv.ColumnCount; j++)
                    //    {
                    //        if (dgv.Columns[j].Visible)  //不导出隐藏的列
                    //        {
                    //            if (dgv[j, i].ValueType == typeof(string))
                    //            {
                    //                excel.Cells[i + 2, k + 1] = "" + dgv[j, i].Value.ToString();
                    //            }
                    //            else
                    //            {
                    //                excel.Cells[i + 2, k + 1] = dgv[j, i].Value.ToString();
                    //            }
                    //        }
                    //        k++;
                    //    }
                    //}
                    //try
                    //{
                    //    excelBook.Saved = true;
                    //    excelBook.SaveCopyAs(fileName);
                    //}
                    //catch
                    //{
                    //    MessageBox.Show("导出失败，文件可能正在使用中","提示");
                    //}
                   
                }
            }
        }
    }


        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // qSGJDataSet.Table_Anli.
            //添加案例的功能
            //创建链接
            SqlConnection conn = null;
            conn = new SqlConnection(Jingtai.ConnectionString);
            conn.Open();
            
            //链接已经创建
            //创建命令对象
            SqlCommand cmd = null;
            //创建语句字符串
            string sql = null;

            sql = @"INSERT INTO Table_Anli VALUES ('" +textBoxANWEIZHI.Text+
                                                 "','"+textBoxANLILOUCENG.Text+
                                                 "','"+textBoxANLIZONGCENG.Text+
                                                 "','"+ comboBoxJIEGOU.Text +
                                                 "','" + comboBoxYONGTU.Text +
                                                 "','"+textBoxANLIMIANJI.Text+
                                                 "','"+textBoxANLIDANJIA.Text+
                                                 "','"+textBoxANLIRIQI.Text+"')";


            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            table_AnliTableAdapter.Fill(qSGJDataSet.Table_Anli); //数据填充回来
            dataGridView1.Focus(); //显示最下面的案例
            SendKeys.Send("^{End}{Home}");
            

            //table_AnliTableAdapter.Insert("1", 2, 3, "4", 5, 6, "7");
            ////table_AnliTableAdapter.GetData();
            //table_AnliTableAdapter.Fill(qSGJDataSet.Table_Anli);

        }

        

        

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {

                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        

        

       

        

        
    }
}
