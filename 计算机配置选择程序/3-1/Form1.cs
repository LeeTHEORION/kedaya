using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_1
{
    public partial class 计算机配置 : Form
    {
        public 计算机配置()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "您选择的配置是：" + "\r\n";
            if (comboBox1.Text == "联想")
                textBox1.Text += comboBox1.Text + "\r\n";
            if (comboBox1.Text == "方正")
                textBox1.Text += comboBox1.Text + "\r\n";
            if (comboBox1.Text == "Dell")
                textBox1.Text += comboBox1.Text + "\r\n";
            if (comboBox1.Text == "兼容机")
                textBox1.Text += comboBox1.Text + "\r\n";
            if (radioButton1.Checked == true)
                textBox1.Text += radioButton1.Text + "\r\n";
            if (radioButton2.Checked == true)
                textBox1.Text += radioButton2.Text + "\r\n";
            if (radioButton3.Checked == true)
                textBox1.Text += radioButton3.Text + "\r\n";
            if (radioButton4.Checked == true)
                textBox1.Text += radioButton4.Text + "\r\n";
            if (radioButton5.Checked == true)
                textBox1.Text += radioButton5.Text + "\r\n";
            if (checkBox1.Checked)
                textBox1.Text += checkBox1.Text + "\r\n";
            if (checkBox2.Checked)
                textBox1.Text += checkBox2.Text + "\r\n";
            if (checkBox3.Checked)
                textBox1.Text += checkBox3.Text + "\r\n";
        }

        


    }
}
