using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace karan_Project
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            StreamReader read2 = new StreamReader("C:\\Users\\karan\\source\\repos\\karan Project\\TextFile2.txt");

            var textform2 = new FileInfo("C:\\Users\\karan\\source\\repos\\karan Project\\TextFile2.txt");
            if (textform2.Length != 0)
            {
                textBox1.Text = read2.ReadLine();
                textBox1.Enabled = false;

                textBox2.Text = read2.ReadLine();
                textBox2.Enabled = false;

                textBox3.Text = read2.ReadLine();
                textBox3.Enabled = false;

                textBox4.Text = read2.ReadLine();
                textBox4.Enabled = false;

            }
            read2.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void submit1_Click(object sender, EventArgs e)
        {

            DialogResult D2 = MessageBox.Show("You want to submit this?");
            if (D2 == DialogResult.OK)
            {
                StreamWriter write2 = new StreamWriter("C:\\Users\\karan\\source\\repos\\karan Project\\TextFile2.txt");

                String name = textBox1.Text;
                write2.WriteLine(name);

                String id = textBox2.Text;
                write2.WriteLine(id);

                String signature = textBox3.Text;
                write2.WriteLine(signature);

                String date = textBox4.Text;
                write2.WriteLine(date);

                write2.Close();

                Close();
            }
        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        // for button1.enabled,I changed the name to submit1_click but it was not working so I wrote button1.enabled, it worked 
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