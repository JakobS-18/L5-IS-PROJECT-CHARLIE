using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Week_3_Charlie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool buttonwasclicked = false;

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                buttonwasclicked = true;
                if (form2.radioButton1.Checked == true)
                    button2.Text = form2.radioButton1.Text;
                else if (form2.radioButton2.Checked == true)
                    button2.Text = form2.radioButton2.Text;
                else if (form2.radioButton3.Checked == true)
                    button2.Text = form2.radioButton3.Text;
                else if (form2.radioButton4.Checked == true)
                    button2.Text = form2.radioButton4.Text;
                else
                    button2.Text = ("Meeting Aim");
            }
            else
            {
                button2.Text = ("Meeting Aim");
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int num = 0;
            if (textBox1.Text == "")//Firstname
            {
                MessageBox.Show("Firstname can't be empty");
                textBox1.BackColor = Color.Red;
                textBox1.Focus();
            }
            else if (textBox2.Text == "")//Surname
            {
                textBox1.BackColor = Color.White;
                MessageBox.Show("Surname can't be empty");
                textBox2.BackColor = Color.Red;
                textBox2.Focus();
            }
            else if (int.TryParse(textBox3.Text, out num) == false)// mobile
            {
                textBox1.BackColor = Color.White;
                textBox2.BackColor = Color.White;
                MessageBox.Show("Enter Digits only");
                textBox3.BackColor = Color.Red;
                textBox3.Focus();
            }
            else if (textBox4.Text == "")//Email
            {
                textBox1.BackColor = Color.White;
                textBox2.BackColor = Color.White;
                textBox3.BackColor = Color.White;
                MessageBox.Show("Email can't be empty");
                textBox2.BackColor = Color.Red;
                textBox4.Focus();
            }
            else if (numericUpDown1.Value == 0)//time
            {
                textBox1.BackColor = Color.White;
                textBox2.BackColor = Color.White;
                textBox3.BackColor = Color.White;
                textBox4.BackColor = Color.White;
                MessageBox.Show("Please enter the hour time:");
                numericUpDown1.Focus();
            }
            else if (numericUpDown2.Value == 0)//time
            {
                textBox1.BackColor = Color.White;
                textBox2.BackColor = Color.White;
                textBox3.BackColor = Color.White;
                textBox4.BackColor = Color.White;
                MessageBox.Show("Please enter the minute time:");
                numericUpDown2.Focus();
            }
            else if (comboBox1.SelectedIndex == -1)//bk combo with drink
            {
                textBox1.BackColor = Color.White;
                textBox2.BackColor = Color.White;
                textBox3.BackColor = Color.White;
                textBox4.BackColor = Color.White;
                MessageBox.Show("Please select any item.");
            }
            else if (button1.Text == "Meeting Aim") //else if (buttonwasclicked == false)//meeting button
            {
                textBox1.BackColor = Color.White;
                textBox2.BackColor = Color.White;
                textBox3.BackColor = Color.White;
                textBox4.BackColor = Color.White;
                MessageBox.Show("Please click the button ");
            }
            //listbox
            else

                listBox1.Items.Add("Meeting of: " + textBox1.Text + " " + textBox2.Text);
                listBox1.Items.Add("Meeting at: " + numericUpDown1.Value + ":" + numericUpDown2.Value);
                listBox1.Items.Add("Meeting with: " + comboBox1.SelectedItem);
                listBox1.Items.Add("Meeting Aim: " + button2.Text);
                listBox1.Items.Add("---------------------------------------------------------------");
            
                textBox1.ResetText();
                textBox2.ResetText();
                textBox3.ResetText();
                textBox4.ResetText();
                dateTimePicker1.ResetText();
                numericUpDown1.Value = 0;
                numericUpDown2.Value = 0;
                comboBox1.Text = "Select Any";
                button2.Text = "Meeting Aim";
            {

            }

        }

        


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {



        }



        private void Form1_Load(object sender, EventArgs e)
        {



        }

        

        


    }
}
       