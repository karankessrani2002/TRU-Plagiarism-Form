using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using System.Diagnostics;

namespace karan_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }
        public void ProgressBar()
        {

            string[] filePaths = new string[]
            {
             "C:\\Users\\karan\\source\\repos\\karan Project\\TextFile1.txt",
             "C:\\Users\\karan\\source\\repos\\karan Project\\TextFile2.txt",
             "C:\\Users\\karan\\source\\repos\\karan Project\\TextFile3.txt",
             "C:\\Users\\karan\\source\\repos\\karan Project\\TextFile4.txt",
             "C:\\Users\\karan\\source\\repos\\karan Project\\TextFile5.txt"
            };


            int nonEmptyFileCount = filePaths.Count(path => new FileInfo(path).Length > 0);


            int progressPercentage = (nonEmptyFileCount * 100) / filePaths.Length;


            progressBar1.Value = progressPercentage;

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 step_1 = new Form2();
            step_1.Show();
            ProgressBar();
        }


        private void button6_Click(object sender, EventArgs e)
        {
            Form3 step_2 = new Form3();
            step_2.Show();
            ProgressBar();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ProgressBar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.WriteAllText("C:\\Users\\karan\\source\\repos\\karan Project\\TextFile1.txt", "");
            File.WriteAllText("C:\\Users\\karan\\source\\repos\\karan Project\\TextFile2.txt", "");
            File.WriteAllText("C:\\Users\\karan\\source\\repos\\karan Project\\TextFile3.txt", "");
            File.WriteAllText("C:\\Users\\karan\\source\\repos\\karan Project\\TextFile4.txt", "");
            File.WriteAllText("C:\\Users\\karan\\source\\repos\\karan Project\\TextFile5.txt", "");


            ProgressBar();

        }
        private void button8_Click(object sender, EventArgs e)
        {
            Form4 step_3 = new Form4();
            step_3.Show();
            ProgressBar();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form5 step_4 = new Form5();
            step_4.Show();
            ProgressBar();
        }

        private void button12_Click(object sender, EventArgs e)
        {

            Form6 step_5 = new Form6();
            step_5.Show();
            ProgressBar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            button4.Visible = true;
            button6.Visible = true;
            button8.Visible = true;
            button10.Visible = true;
            button12.Visible = true;
            File.WriteAllText("C:\\Users\\karan\\source\\repos\\karan Project\\TextFile1.txt", "");
            File.WriteAllText("C:\\Users\\karan\\source\\repos\\karan Project\\TextFile2.txt", "");
            File.WriteAllText("C:\\Users\\karan\\source\\repos\\karan Project\\TextFile3.txt", "");
            File.WriteAllText("C:\\Users\\karan\\source\\repos\\karan Project\\TextFile4.txt", "");
            File.WriteAllText("C:\\Users\\karan\\source\\repos\\karan Project\\TextFile5.txt", "");



            ProgressBar();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

            ProgressBar();
        }
        void Search()
        {
            var pyexe = @"C:\Users\karan\AppData\Local\Microsoft\WindowsApps\python.exe";
            var filePath = @"C:\Users\karan\source\repos\karan Project\script.py";
            var form2 = @"C:\Users\karan\source\repos\karan Project\TextFile1.txt";
            var form3 = @"C:\Users\karan\source\repos\karan Project\TextFile2.txt";
            var form4 = @"C:\Users\karan\source\repos\karan Project\TextFile3.txt";
            var form5 = @"C:\Users\karan\source\repos\karan Project\TextFile4.txt";
            var form6 = @"C:\Users\karan\source\repos\karan Project\TextFile5.txt";
            var searchTerm = textBox1.Text;

            var startInfo = new ProcessStartInfo();
            startInfo.FileName = pyexe;
            startInfo.Arguments = $"\"{filePath}\" \"{form2}\" \"{form3}\" \"{form4}\" \"{form5}\" \"{form6}\" \"{searchTerm}\"";
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;

            using (var process = Process.Start(startInfo))
            {
                using (var reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    textBox2.Text = result;
                    textBox2.Enabled = false;
                }

                string errors = process.StandardError.ReadToEnd();
                if (!string.IsNullOrEmpty(errors))
                {
                    MessageBox.Show(errors);
                }
            }

            
            string[] lines = textBox2.Text.Split('\n');
            foreach (string line in lines)
            {
                Console.WriteLine("Processing line: " + line); 
                if (line.Contains("The term '"))
                {
                    int startIndex = line.IndexOf("found in ") + "found in ".Length;
                    int endIndex = line.IndexOf(".", startIndex);
                    Console.WriteLine("startIndex: " + startIndex); 
                    Console.WriteLine("endIndex: " + endIndex); 
                    string form = line.Substring(startIndex, endIndex - startIndex).Trim();
                    if (!string.IsNullOrEmpty(form))
                    {
                        MessageBox.Show($"The search term was found in {form}");
                    }
                    else
                    {
                        MessageBox.Show("not found.");
                    }
                }
            }
        }






        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

