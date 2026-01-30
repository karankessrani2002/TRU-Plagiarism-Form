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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            StreamReader read1 = new StreamReader("C:\\Users\\karan\\source\\repos\\karan Project\\TextFile1.txt");

            var textform1 = new FileInfo("C:\\Users\\karan\\source\\repos\\karan Project\\TextFile1.txt");
            if (textform1.Length != 0)
            {
                textBox1.Text = read1.ReadLine();
                textBox1.Enabled = false; 
                textBox2.Text = read1.ReadLine();
                textBox2.Enabled = false;

                textBox3.Text = read1.ReadLine();
                textBox3.Enabled = false;

                textBox4.Text = read1.ReadLine();
                textBox4.Enabled = false;

                textBox5.Text = read1.ReadLine();
                textBox5.Enabled = false;

                textBox6.Text = read1.ReadLine();
                textBox6.Enabled = false;

                textBox7.Text = read1.ReadLine();
                textBox7.Enabled = false;

                textBox8.Text = read1.ReadLine();
                textBox8.Enabled = false;

                textBox9.Text = read1.ReadLine();
                textBox9.Enabled =false;

                textBox13.Text = read1.ReadLine();
                textBox13.Enabled = false;

                textBox14.Text = read1.ReadLine();
                textBox14.Enabled = false;

                textBox15.Text = read1.ReadLine();
                textBox15.Enabled = false;

                textBox16.Text = read1.ReadLine();
                textBox16.Enabled = false;

                checkBox3.Enabled = false;

                checkBox4.Enabled = false;

            }

            read1.Close();
        }



        private void submit_Click(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("You want to submit this?");
            if (DR == DialogResult.OK)
            {
                StreamWriter write1 = new StreamWriter("C:\\Users\\karan\\source\\repos\\karan Project\\TextFile1.txt");

                String name = textBox1.Text;
                write1.WriteLine(name);


                String id = textBox2.Text;
                write1.WriteLine(id);

                String email = textBox3.Text;
                write1.WriteLine(email);

                String faculty = textBox4.Text;
                write1.WriteLine(faculty);

                String date = textBox5.Text;
                write1.WriteLine(date);

                String course = textBox6.Text;
                write1.WriteLine(course);

                String assignment = textBox7.Text;
                write1.WriteLine(assignment);

                String department = textBox8.Text;
                write1.WriteLine(department);

                String term = textBox9.Text;
                write1.WriteLine(term);

                String description = textBox13.Text;
                write1.WriteLine(description);

                String signature_faculty = textBox14.Text;
                write1.WriteLine(signature_faculty);

                String signature_name = textBox15.Text;
                write1.WriteLine(signature_name);

                String signature_date = textBox16.Text;
                write1.WriteLine(signature_date);

                write1.Close();

                Close();
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        // for button1.enabled,I changed the name to submit_click but it was not working so I wrote button1.enabled, it worked 
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true || checkBox4.Checked == true)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox3.Checked == true || checkBox4.Checked == true)
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