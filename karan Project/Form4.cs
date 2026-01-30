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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace karan_Project
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            StreamReader read3 = new StreamReader("TextFile3.txt");

            var textform3 = new FileInfo("TextFile3.txt");
            if (textform3.Length != 0)
            {
                textBox1.Text = read3.ReadLine();
                textBox1.Enabled = false;

                textBox2.Text = read3.ReadLine();
                textBox2.Enabled = false;

                textBox3.Text = read3.ReadLine();
                textBox3.Enabled = false;



            }
            read3.Close();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult D3 = MessageBox.Show("You want to submit this?");
            if (D3 == DialogResult.OK)
            {
                StreamWriter write3 = new StreamWriter("TextFile3.txt");

                String siganture = textBox1.Text;
                write3.WriteLine(siganture);

                String name = textBox2.Text;
                write3.WriteLine(name);

                String date = textBox3.Text;
                write3.WriteLine(date);


                write3.Close();

                Close();
            }
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }




}