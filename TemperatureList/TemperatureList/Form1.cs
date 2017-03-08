using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperatureList
{
    public partial class Form1 : Form
    {
        int[] temps = { 9999, 9999, 9999, 9999, 9999, 9999, 9999, 9999 };
        public int Todaystemp = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Todaystemp = Convert.ToInt32(textBox1.Text);
                for (int i = 0; i < 7; i++)
                {
                    if (temps[i] == 9999)
                    {
                        temps[i] = Todaystemp;
                        if (i == 0)
                        {
                            label1.Text = Todaystemp + " degrees";
                        }
                        else if (i == 1)
                        {
                            label2.Text = Todaystemp + " degrees";
                        }
                        else if (i == 2)
                        {
                            label3.Text = Todaystemp + " degrees";
                        }
                        else if (i == 3)
                        {
                            label4.Text = Todaystemp + " degrees";
                        }
                        else if (i == 4)
                        {
                            label5.Text = Todaystemp + " degrees";
                        }
                        else if (i == 5)
                        {
                            label6.Text = Todaystemp + " degrees";
                        }
                        else if (i == 6)
                        {
                            label7.Text = Todaystemp + " degrees";
                        }
                        break;
                    }
                }
            }
            catch (SystemException)
            {
                MessageBox.Show("Error. Invalid values entered.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int dayindex = Convert.ToInt32(textBox2.Text) - 1;
                int day = Convert.ToInt32(textBox2.Text);
                int sum = 0;
                int days = 0;
                foreach (int value in temps)
                {
                    if (value != 9999)
                    {
                        sum += value;
                        days++;
                    }

                }
                int average = sum / days;
                int diff = Math.Abs(average - temps[dayindex] );
                label8.Text = "The average temperature is " + average + " degrees. ";
                label9.Text = "The temperature on day " + day + " was " + diff + " degrees from the average.";
            }

            catch (SystemException)
            {
                MessageBox.Show("Error. Invalid value entered.");
            }
        }
    }
}
