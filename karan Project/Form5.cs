using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace karan_Project
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            StreamReader read4 = new StreamReader("C:\\Users\\karan\\source\\repos\\karan Project\\TextFile4.txt");

            var textform4 = new FileInfo("C:\\Users\\karan\\source\\repos\\karan Project\\TextFile4.txt");
            if (textform4.Length != 0)
            {
                textBox1.Text = read4.ReadLine();
                textBox1.Enabled = false;

                textBox2.Text = read4.ReadLine();
                textBox2.Enabled = false;

                textBox3.Text = read4.ReadLine();
                textBox3.Enabled = false;

                textBox4.Text = read4.ReadLine();
                textBox4.Enabled = false;

                textBox5.Text = read4.ReadLine();
                textBox5.Enabled = false;

            }
            read4.Close();
        }
    

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

       

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult D4 = MessageBox.Show("You want to submit this?");
            if (D4 == DialogResult.OK)
            {
                StreamWriter write4 = new StreamWriter("C:\\Users\\karan\\source\\repos\\karan Project\\TextFile4.txt");

                String explain = textBox1.Text;
                write4.WriteLine(explain);

                String comments = textBox2.Text;
                write4.WriteLine(comments);

                String signature = textBox3.Text;
                write4.WriteLine(signature);

                String name = textBox4.Text;
                write4.WriteLine(name);

                String date = textBox5.Text;
                write4.WriteLine(date);

                write4.Close();

                Close();
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true || checkBox2.Checked == true)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true || checkBox2.Checked == true)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }
    }
}
