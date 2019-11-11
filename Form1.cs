using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatorApp
{
    public partial class Form1 : Form
    {
        double Result;
        double SecondNumber;
        double FirstNumber;
        //string operation=textBox1.Text.Substring(t,1);
        public Form1()
        {
            InitializeComponent();
        }

        private void n2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "0" && textBox1 != null)
                {
                    textBox1.Text = "2";
                }
                else
                {
                    textBox1.Text = textBox1.Text + "2";
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Nmber is too large");
            }
        }

        private void n1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "0" && textBox1 != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void n3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1 != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void n4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1 != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void n5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1 != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void n6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1 != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void n7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1 != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void n8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1 != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void n9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1 != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void n0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1 != null)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }
        
        private void bdiv_Click(object sender, EventArgs e)
        {
            //FirstNumber = Convert.ToDouble(textBox1.Text.Substring(0, t));
            textBox1.Text = textBox1.Text + "/";
            //operation = "/";
        }

        private void bmult_Click(object sender, EventArgs e)
        {
            //FirstNumber = Convert.ToDouble(textBox1.Text.Substring(0, t));
            textBox1.Text = textBox1.Text + "*";
            //operation = "*";
        }

        private void bad_Click(object sender, EventArgs e)
        {
            //FirstNumber = Convert.ToDouble(textBox1.Text.Substring(0, t));
            textBox1.Text = textBox1.Text + "+";
            //operation = "+";
        }

        private void bsub_Click(object sender, EventArgs e)
        {
            //FirstNumber = Convert.ToDouble(textBox1.Text.Substring(0, t));
            textBox1.Text = textBox1.Text + "-";
            //operation = "-";
        }

        private void bc_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void bdot_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void bequal_Click(object sender, EventArgs e)
        {
            try
            {
                int t = 0;
                if (textBox1.Text.Contains("+"))
                {
                    t = textBox1.Text.IndexOf("+");
                }
                else if (textBox1.Text.Contains("-"))
                {
                    t = textBox1.Text.IndexOf("-");
                }
                else if (textBox1.Text.Contains("*"))
                {
                    t = textBox1.Text.IndexOf("*");
                }
                else if (textBox1.Text.Contains("/"))
                {
                    t = textBox1.Text.IndexOf("/");
                }

                string operation = textBox1.Text.Substring(t, 1);

                FirstNumber = Convert.ToDouble(textBox1.Text.Substring(0, t));
                //double SecondNumber;

                

                SecondNumber = Convert.ToDouble(textBox1.Text.Substring(t + 1, textBox1.Text.Length - t - 1));


                if (operation == "+")
                {
                    HISTORY.Items.Add(textBox1.Text + "=" + (FirstNumber + SecondNumber));
                    Result = (FirstNumber + SecondNumber);
                    textBox1.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
                if (operation == "-")
                {
                    HISTORY.Items.Add(textBox1.Text + "=" + (FirstNumber - SecondNumber));
                    Result = (FirstNumber - SecondNumber);
                    textBox1.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
                if (operation == "*")
                {
                    HISTORY.Items.Add(textBox1.Text + "=" + (FirstNumber * SecondNumber));
                    Result = (FirstNumber * SecondNumber);
                    textBox1.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
                if (operation == "/")
                {
                    if (textBox1.Text == "0")
                    {
                        textBox1.Text = "Cannot Divide by zero";
                    }
                    else
                    {
                        HISTORY.Items.Add(textBox1.Text + "=" + (FirstNumber / SecondNumber));
                        Result = (FirstNumber / SecondNumber);
                        textBox1.Text = Convert.ToString(Result);
                        FirstNumber = Result;
                    }
                }
            }
            catch
            {
                textBox1.Text = "error";
            }

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void hISTORYToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            HISTORY.Items.Add(textBox1.Text + "=" + (FirstNumber / SecondNumber));
            //HISTORY.Items.Add(textBox1.Text + "=" + (FirstNumber * SecondNumber));
            //HISTORY.Items.Add(textBox1.Text + "=" + (FirstNumber - SecondNumber));
            //HISTORY.Items.Add(textBox1.Text + "=" + (FirstNumber + SecondNumber));
        }

        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
