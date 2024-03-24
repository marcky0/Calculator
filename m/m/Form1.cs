using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace m
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string Caltotal;
        int num1;
        int num2;
        string option;
        int result;


        private void btn5_Click(object sender, EventArgs e)
        {
            int btn = 3;
            txttotal.Text = (int.Parse(txttotal.Text + btn)).ToString();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int btn = 4;
            txttotal.Text = (int.Parse(txttotal.Text + btn)).ToString();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            int btn = 3;
            txttotal.Text = (int.Parse(txttotal.Text + btn)).ToString();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            int btn = 2;
            txttotal.Text = (int.Parse(txttotal.Text + btn)).ToString();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            int btn = 5;
            txttotal.Text = (int.Parse(txttotal.Text + btn)).ToString();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            int btn = 3;
            txttotal.Text = (int.Parse(txttotal.Text + btn)).ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txttotal.Clear();
            txttotal.Clear();
            result = (0);
            num1 = (0);
            num2 = (0);

        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = Convert.ToInt32(txttotal.Text);
            txttotal.Clear();

        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = Convert.ToInt32(txttotal.Text);
            txttotal.Clear();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = Convert.ToInt32(txttotal.Text);
            txttotal.Clear();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = Convert.ToInt32(txttotal.Text);
            txttotal.Clear();

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToInt32(txttotal.Text);

            if (option.Equals("+"))
                result = num1 + num2;

            if (option.Equals("-"))
                result = num1 - num2;

            if (option.Equals("*"))
                result = num1 * num2;

            if (option.Equals("/"))
                result = num1 / num2;

            txttotal.Text = result.ToString(); // Set the result as the current total
            num1 = result; // Store the result for consecutive operations
        }


        private void btntotal_Click(object sender, EventArgs e)
        {
            txttotal.Text = result.ToString();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}