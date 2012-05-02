using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox5.Text = sa.ProceedSwap(sa.GetAr(), sa.GetI1(), sa.GetI2(), sa.GetSize());
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                sa.SetAr(textBox1.Text);
                label3.Text = "(от 1 до " + Convert.ToString(textBox1.TextLength / 2) + ")";
                textBox2.Enabled = true; label3.Enabled = true;
                textBox2.Focus();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                textBox2.Text = sa.SetSize(textBox2.Text);
                if (sa.GetSize() != -1)
                {
                    label5.Text = "(от 1 до " + Convert.ToString(sa.maxI1 + 1) + ")";
                    textBox3.Enabled = true; label5.Enabled = true;
                }
            textBox3.Focus(); 
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                textBox3.Text = sa.SetI1(textBox3.Text);
                label7.Text = "(от " + Convert.ToString(sa.minI2 + 1) + " до " + Convert.ToString(sa.maxI2 + 1) + ")";
                if (sa.GetI1() > -1)
                    textBox4.Enabled = true; label7.Enabled = true;
                textBox4.Focus(); 
            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                textBox4.Text = sa.SetI2(textBox4.Text);
                if (sa.GetI2() > -1) button1.Enabled = true;
                button1.Focus(); 
            }
        }
    }
}
