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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            StreamReader read4 = new StreamReader("C:\\Users\\karan\\source\\repos\\karan Project\\TextFile5.txt");

            var textform4 = new FileInfo("C:\\Users\\karan\\source\\repos\\karan Project\\TextFile5.txt");
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult D5 = MessageBox.Show("You want to submit this?");
            if (D5 == DialogResult.OK)
            {
                StreamWriter write5 = new StreamWriter("C:\\Users\\karan\\source\\repos\\karan Project\\TextFile5.txt");

                String explain = textBox1.Text;
                write5.WriteLine(explain);

                String signature = textBox2.Text;
                write5.WriteLine(signature);

                String name = textBox3.Text;
                write5.WriteLine(name);

                String date = textBox4.Text;
                write5.WriteLine(date);

                String comments = textBox5.Text;
                write5.WriteLine(comments);

                write5.Close();

                Close();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
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
