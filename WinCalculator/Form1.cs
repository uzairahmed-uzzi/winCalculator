﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinCalculator
{
    public partial class Form1 : Form
    {
        double val1=0.0d;
        string ope="";
        double res = 0.0f;


        public Form1()
        {
            InitializeComponent();
        }
       
        public void checkEmpty(string o)
        {
            if (txtResultBox.Text != "") {    
             val1 = Convert.ToDouble(txtResultBox.Text);
             ope = o;
            txtResultBox.Text = "";
            }
        }
        private void btnOne_Click(object sender, EventArgs e)
        {
            txtResultBox.Text += "1";
            
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtResultBox.Text += "2";
            
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            txtResultBox.Text += "3";
            
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            txtResultBox.Text += "4";
            
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txtResultBox.Text += "5";
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResultBox.Text = "";
            val1 = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            checkEmpty("+");

        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            
            try { 
                if (txtResultBox.Text != "") { 
                    if (ope == "+")
                    {
                        res = val1 + Convert.ToDouble(txtResultBox.Text);
                        
                    }
                    else if (ope == "-")
                    {
                        res = val1 - Convert.ToDouble(txtResultBox.Text);
                    }
                    else if (ope == "*")
                    {
                        res = val1 * Convert.ToDouble(txtResultBox.Text);
                    }
                    else if (ope == "/")
                    {
                        res = val1 / Convert.ToDouble(txtResultBox.Text);
                    }
                    txtResultBox.Text = res.ToString();
                    val1 = 0;
                    ope = "";
                }
            }
            catch { }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            checkEmpty("-");
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            txtResultBox.Text += "6";
            
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtResultBox.Text += "7";
            
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            txtResultBox.Text += "8";
            
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            txtResultBox.Text += "9";
            
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtResultBox.Text += "0";
            
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            txtResultBox.Text += ".";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            checkEmpty("/");
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            checkEmpty("*");
        }

        private void btnPercen_Click(object sender, EventArgs e)
        {
            if (txtResultBox.Text != "") { 
            val1 = Convert.ToDouble(txtResultBox.Text);
            val1 /= 100;
            txtResultBox.Text = val1.ToString();
            }
        }

        private void btnSqr_Click(object sender, EventArgs e)
        {
            if (txtResultBox.Text != "")
            {
                val1 = Convert.ToDouble(txtResultBox.Text);
                val1 *= val1;
                txtResultBox.Text = val1.ToString();
            }
        }
    }
}
       


     
       

       
       

 