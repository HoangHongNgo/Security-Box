using System.Collections.Generic;
using System;
using System.Data.Common;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("time", "Time");
            dataGridView1.Columns.Add("action", "Action");
            readTxt();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 4)
                textBox1.Text = textBox1.Text.Insert(textBox1.Text.Length, "1");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 4)
                textBox1.Text = textBox1.Text.Insert(textBox1.Text.Length, "2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 4)
                textBox1.Text = textBox1.Text.Insert(textBox1.Text.Length, "3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 4)
                textBox1.Text = textBox1.Text.Insert(textBox1.Text.Length, "4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 4)
                textBox1.Text = textBox1.Text.Insert(textBox1.Text.Length, "5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 4)
                textBox1.Text = textBox1.Text.Insert(textBox1.Text.Length, "6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 4)
                textBox1.Text = textBox1.Text.Insert(textBox1.Text.Length, "7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 4)
                textBox1.Text = textBox1.Text.Insert(textBox1.Text.Length, "8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 4)
                textBox1.Text = textBox1.Text.Insert(textBox1.Text.Length, "9");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 4)
                textBox1.Text = textBox1.Text.Insert(textBox1.Text.Length, "0");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string action;
            if (textBox1.Text == "1234")
            {
                MessageBox.Show("Access");
                action = "Access";
                textBox1.Clear();
            }
            else { MessageBox.Show("Denied"); action = "Denied"; } ;
            dataGridView1.Rows.Add(DateTime.Now, action);


        }
        private void readTxt()
        {
            string line;
            // Read the file and display it line by line.
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\Hong Hoang\source\repos\WinFormsApp2\WinFormsApp2\TextFile1.txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] words = line.Split(',');
                try { dataGridView1.Rows.Add(words[0], words[1]); }
                catch { MessageBox.Show("Log or Log file doesn't exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                
            }
            file.Close();
        }
        private void saveToTxt()
        {
            //This line of code creates a text file for the data export.
            System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Hong Hoang\source\repos\WinFormsApp2\WinFormsApp2\TextFile1.txt");
            try
            {
                string sLine = "";

                //This for loop loops through each row in the table
                for (int r = 0; r < dataGridView1.Rows.Count - 1; r++)
                {
                    //This for loop loops through each column, and the row number
                    //is passed from the for loop above.
                    for (int c = 0; c < dataGridView1.Columns.Count; c++)
                    {
                        sLine = sLine + dataGridView1.Rows[r].Cells[c].Value;
                        if (c != dataGridView1.Columns.Count - 1)
                        {
                            //A comma is added as a text delimiter in order
                            //to separate each field in the text file.
                            sLine = sLine + ",";
                        }
                    }
                    //The exported text is written to the text file, one line at a time.
                    file.WriteLine(sLine);
                    sLine = "";
                }

                file.Close();
                MessageBox.Show("Export Complete.", "Program Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                file.Close();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveToTxt();
        }
    }
}
