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

namespace Digital_Diary
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
           
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MemoriesBox.Items.Add(textBox1.Text);

            if (textBox1.Text != "" && textBox2.Text != "")
                if (textBox1.Text != "")

                    if (MemoriesComboBox.Items.Contains(textBox1.Text))
                    {
                        
                        MessageBox.Show("Items Already Exists");
                    }

                    else
                    {
                        MemoriesComboBox.Items.Add(textBox1.Text);
                        textBox1.Clear();
                        textBox1.Focus();//for keeping cartcert on that button
                    }
                else
                {

                    MemoriesBox.Items.Add(textBox1.Text);
                    MessageBox.Show("Create new event");
                }

          else
            {

                textBox1.Clear();
                textBox1.Focus();
                MessageBox.Show("fill the blanks");
            }
            
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
            textBox2.Focus();
            textBox3.Clear();
            textBox3.Focus();
            
            pictureBox1.Visible = true;
            MemoriesComboBox.Visible = true;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MemoriesBox.Items.Remove(MemoriesBox.SelectedItem);
            MemoriesComboBox.Items.Remove(MemoriesComboBox.SelectedItem);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp;)|*.jpg; *.jpeg; *.gif; *.bmp;";
            if(open.ShowDialog()==DialogResult.OK)
            {
                textBox3.Text = open.FileName;
                pictureBox1.Image = new Bitmap(open.FileName);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text);
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MemoriesComboBox.SelectedIndex > 0 || MemoriesComboBox.SelectedIndex == 0)
            {
                string gettex = MemoriesComboBox.SelectedItem.ToString();

                MessageBox.Show("Event Name:" + gettex);
                MessageBox.Show("Date:" + dateTimePicker1.Value);
                MessageBox.Show("Description:" + textBox2.Text);
                MessageBox.Show("Picture:" + pictureBox1.Image); 

               
            }
                    
        }

        private void button5_Click(object sender, EventArgs e)
        {

            
            MemoriesComboBox.Sorted = true;
            
        }
    }
}
