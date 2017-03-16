using System;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                float a = Convert.ToInt16(textBox1.Text);
                float b = Convert.ToInt16(textBox2.Text);
                float r = a + b;
                button1.Text = r.ToString();
            }
            catch (Exception a)
            {
                MessageBox.Show("Error:" + a.Message, "Error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                float c = Convert.ToInt16(textBox3.Text);
                float d = Convert.ToInt16(textBox4.Text);
                float r = c - d;
                button2.Text = r.ToString();
            }
            catch (Exception a)
            {
                MessageBox.Show("Error:" + a.Message, "Error");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                float d = Convert.ToInt16(textBox5.Text);
                float e1 = Convert.ToInt16(textBox6.Text);
                float r = d * e1;
                button3.Text = r.ToString();
            }
            catch (Exception a)
            {
                MessageBox.Show("Error:" + a.Message, "Error");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                float f = Convert.ToInt16(textBox7.Text);
                float g = Convert.ToInt16(textBox8.Text);
                if (g == 0)
                {
                    MessageBox.Show("Divison by 0 invalid", "Division by 0");
                }
                float r = f / g;
                button4.Text = r.ToString();
            }
            catch (Exception a)
            {
                MessageBox.Show("Error:" + a.Message, "Error");
            }
        }
    }
}
