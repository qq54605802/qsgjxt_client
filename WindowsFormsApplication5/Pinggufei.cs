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
    public partial class Pinggufei : Form
    {
        public Pinggufei()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //房地产司法放进去
            try
            {
                if (double.Parse(textBoxJSPINGGUE.Text) <= 5000000)
                {
                    textBoxFANGDICHANSIFA.Text = (double.Parse(textBoxJSPINGGUE.Text) * 0.01).ToString("n");
                }
                else if (double.Parse(textBoxJSPINGGUE.Text) > 5000000 && double.Parse(textBoxJSPINGGUE.Text) <= 10000000)
                {
                    textBoxFANGDICHANSIFA.Text = (50000 + (double.Parse(textBoxJSPINGGUE.Text) - 5000000) * 0.006).ToString("n");
                }
                else if (double.Parse(textBoxJSPINGGUE.Text) > 10000000 && double.Parse(textBoxJSPINGGUE.Text) <= 20000000)
                {
                    textBoxFANGDICHANSIFA.Text = (80000 + (double.Parse(textBoxJSPINGGUE.Text) - 10000000) * 0.004).ToString("n");
                }
                else if (double.Parse(textBoxJSPINGGUE.Text) > 20000000 && double.Parse(textBoxJSPINGGUE.Text) <= 50000000)
                {
                    textBoxFANGDICHANSIFA.Text = (120000 + (double.Parse(textBoxJSPINGGUE.Text) - 20000000) * 0.002).ToString("n");
                }
                else if (double.Parse(textBoxJSPINGGUE.Text) > 50000000)
                {
                    textBoxFANGDICHANSIFA.Text = "5千万部分按照18万评估费收取，多出部分协商收取";
                }
            }
            catch
            {
                textBoxFANGDICHANSIFA.Text = "异常";
            }

            //普通房地产评估
            try
            {
                if (double.Parse(textBoxJSPINGGUE.Text) <= 1000000)
                {
                    textBoxFANGDICHAN.Text = (double.Parse(textBoxJSPINGGUE.Text) * 0.005).ToString("n");
                }
                else if (double.Parse(textBoxJSPINGGUE.Text) > 1000000 && double.Parse(textBoxJSPINGGUE.Text) <= 10000000)
                {
                    textBoxFANGDICHAN.Text = (5000 + (double.Parse(textBoxJSPINGGUE.Text) - 1000000) * 0.0025).ToString("n");
                }


                else if (double.Parse(textBoxJSPINGGUE.Text) > 10000000 && double.Parse(textBoxJSPINGGUE.Text) <= 20000000)
                {
                    textBoxFANGDICHAN.Text = (27500 + (double.Parse(textBoxJSPINGGUE.Text) - 10000000) * 0.0015).ToString("n");
                }


                else if (double.Parse(textBoxJSPINGGUE.Text) > 20000000 && double.Parse(textBoxJSPINGGUE.Text) <= 50000000)
                {
                    textBoxFANGDICHAN.Text = (42500 + (double.Parse(textBoxJSPINGGUE.Text) - 20000000) * 0.0008).ToString("n");
                }


                else if (double.Parse(textBoxJSPINGGUE.Text) > 50000000 && double.Parse(textBoxJSPINGGUE.Text) <= 80000000)
                {
                    textBoxFANGDICHAN.Text = (66500 + (double.Parse(textBoxJSPINGGUE.Text) - 50000000) * 0.0004).ToString("n");
                }
                else if (double.Parse(textBoxJSPINGGUE.Text) > 80000000 && double.Parse(textBoxJSPINGGUE.Text) <= 100000000)
                {
                    textBoxFANGDICHAN.Text = (78500 + (double.Parse(textBoxJSPINGGUE.Text) - 80000000) * 0.0002).ToString("n");
                }
                else if (double.Parse(textBoxJSPINGGUE.Text) > 100000000)
                {
                    textBoxFANGDICHAN.Text = (82500 + (double.Parse(textBoxJSPINGGUE.Text) - 100000000) * 0.0001).ToString("n");
                }

            }
            catch
            {
                textBoxFANGDICHANSIFA.Text = "异常";
            }


        }

        private void textBoxFANGDICHAN_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxFANGDICHANSIFA_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxJSPINGGUE_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
