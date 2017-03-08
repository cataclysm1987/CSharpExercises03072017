using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayDemo
{
    public partial class ArrayDemo : Form
    {
        int[] array = new int[8];

        public ArrayDemo()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == 0)
                    {
                        array[i] = Convert.ToInt32(txtArrayValues.Text);
                        break;
                    }
                }
                lblArrayOutput.Text = "";

                foreach (int value in array)
                {
                    if (value != 0)
                    lblArrayOutput.Text += value + " ";
                }
            }

            catch (SystemException)
            {
                MessageBox.Show("Invalid values entered.");
            }

            

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblArrayOutput.Text = "";
            int[] reverse = new int[8];
            Array.Copy(array, reverse, 8);
            Array.Reverse(reverse);
            foreach (int value in reverse)
            {
                if (value != 0)
                lblArrayOutput.Text += value + " ";
            }
        }

        private void btnGetIndex_Click(object sender, EventArgs e)
        {
            try
            {
                int index = Convert.ToInt32(txtNthValue.Text) - 1;
                lblNthValue.Text = array[index].ToString();
            }
            catch (SystemException)
            {
                MessageBox.Show("Invalid value entered.");
            }
        }
    }
}
