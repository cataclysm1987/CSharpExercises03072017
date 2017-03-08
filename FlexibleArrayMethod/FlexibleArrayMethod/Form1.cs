using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlexibleArrayMethod
{
    public partial class Form1 : Form
    {
        public int[] array1 = new int[3];
        public int[] array2 = new int[3];
        public int[] array3 = new int[3];

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd1_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < array1.Length; i++)
                {

                    if (array1[i] == 0)
                    {
                        array1[i] = Convert.ToInt32(txt1Value.Text);
                        if (i == 0)
                        {
                            label1.Text = "Array 1 Value 1: " + array1[i];
                        } else if (i == 1)
                        {
                            label2.Text = "Array 1 Value 2: " + array1[i];
                        }
                        else
                        {
                            label3.Text = "Array 1 Value 3: " + array1[i];
                        }
                        
                        break;
                    }
                }
            }
            catch (SystemException)
            {
                MessageBox.Show("Invalid values entered. Please try again.");
            }
            
        }

        private void btn1Sum_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach (int value in array1)
            {
                sum += value;
            }
            label4.Text = "Array 1 Sum: " + sum;
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < array2.Length; i++)
                {

                    if (array2[i] == 0)
                    {
                        array2[i] = Convert.ToInt32(txtValue2.Text);
                        if (i == 0)
                        {
                            label5.Text = "Array 2 Value 1: " + array2[i];
                        }
                        else if (i == 1)
                        {
                            label6.Text = "Array 2 Value 2: " + array2[i];
                        }
                        else
                        {
                            label7.Text = "Array 2 Value 3: " + array2[i];
                        }

                        break;
                    }
                }
            }
            catch (SystemException)
            {
                MessageBox.Show("Invalid values entered. Please try again.");
            }
        }

        private void btn2Sum_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach (int value in array2)
            {
                sum += value;
            }
            label8.Text = "Array 2 Sum: " + sum;
        }

        private void btnAdd3_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < array3.Length; i++)
                {

                    if (array3[i] == 0)
                    {
                        array3[i] = Convert.ToInt32(txtValue3.Text);
                        if (i == 0)
                        {
                            label9.Text = "Array 3 Value 1: " + array3[i];
                        }
                        else if (i == 1)
                        {
                            label10.Text = "Array 3 Value 2: " + array3[i];
                        }
                        else
                        {
                            label11.Text = "Array 3 Value 3: " + array3[i];
                        }

                        break;
                    }
                }
            }
            catch (SystemException)
            {
                MessageBox.Show("Invalid values entered. Please try again.");
            }
        }

        private void btn3Sum_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach (int value in array3)
            {
                sum += value;
            }
            label12.Text = "Array 3 Sum: " + sum;
        }
    }
}
