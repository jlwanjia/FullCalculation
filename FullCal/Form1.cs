using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FullCal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double tmp = 0;
        double lstNum;
        string calSlt = "+";
        bool eql = false;
        double mem = 0;
        
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
            textBox2.Text = textBox2.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
            textBox2.Text = textBox2.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
            textBox2.Text = textBox2.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
            textBox2.Text = textBox2.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
            textBox2.Text = textBox2.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
            textBox2.Text = textBox2.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
            textBox2.Text = textBox2.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
            textBox2.Text = textBox2.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
            textBox2.Text = textBox2.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
            textBox2.Text = textBox2.Text + "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
            textBox2.Text = textBox2.Text + ".";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "+";
            calTmp();
            calSlt = "+";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            lstNum = Convert.ToDouble(textBox2.Text);
            if (calSlt == "+")
            {
                textBox2.Text = Convert.ToString(tmp + lstNum);
            }
            else if (calSlt == "-")
            {
                textBox2.Text = Convert.ToString(tmp - lstNum);
            }
            else if (calSlt == "*")
            {
                textBox2.Text = Convert.ToString(tmp * lstNum);
            }
            else if (calSlt =="/")
            {
                if (lstNum != 0)
                {
                    textBox2.Text = Convert.ToString(tmp / lstNum);
                }
                else
                {
                    textBox2.Text = ("error");
                }
            }
            else
            {
                textBox2.Text = ("error");
            }
            eql = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "-";
            calTmp();
            calSlt = "-";
        }
        public void calTmp()
        {
            if (eql)
            {
                tmp = Convert.ToDouble(textBox2.Text);
            }
            else
            {
                if (calSlt == "-")
                {
                    tmp -= Convert.ToDouble(textBox2.Text);
                }
                else if (calSlt == "*")
                {
                    tmp *= Convert.ToDouble(textBox2.Text);
                }
                else if (calSlt == "/")
                {
                    if (Convert.ToDouble(textBox2.Text) != 0)
                    {
                        tmp /= Convert.ToDouble(textBox2.Text);
                    }
                    else
                    {
                        textBox2.Text = "error";
                    }
                }
                else
                {
                    tmp += Convert.ToDouble(textBox2.Text);
                }
            }
            eql = false;
            textBox2.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "*";
            calTmp();
            calSlt = "*";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "/";
            calTmp();
            calSlt = "/";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            tmp = 0;
            lstNum = 0;
            calSlt = "+";
            eql = false;
            mem = 0;
           
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = Convert .ToString(mem);
                textBox1.Text += Convert .ToString(mem);
            }
            else
            {
                mem = Convert.ToDouble(textBox2.Text);
            }
           
        }
    }
}
