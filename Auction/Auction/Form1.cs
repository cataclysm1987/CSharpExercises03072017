using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auction
{
        
        
    public partial class Form1 : Form
    {
        public int highestBid = 260;

        public void AcceptBid(int bid)
        {
            if (bid >= highestBid)
            {
                lblCurrent.Text = "Current Bid: $" + bid;
                MessageBox.Show("You won the auction for " + bid + " dollars!");
            }
            else
            {
                lblCurrent.Text = "Current Bid: $" + highestBid;
                MessageBox.Show("You lost the auction. The winner bid " + highestBid + " but your bid was only " + bid);
            }
        }

        public void AcceptBid(double bid)
        {
            if (bid >= highestBid)
            {
                lblCurrent.Text = "Current Bid: $" + bid;
                MessageBox.Show("You won the auction for " + bid + " dollars!");
            }
            else
            {
                lblCurrent.Text = "Current Bid: $" + highestBid;
                MessageBox.Show("You lost the auction. The winner bid $" + highestBid + " but your bid was only $" + bid);
            }
        }

        public void AcceptBid(string bidstring)
        {
            try
            {
                string pattern = "\\$";
                string replacement = "";
                Regex rgx = new Regex(pattern);
                string result = rgx.Replace(bidstring, replacement);
                int bid = Int32.Parse(result);

                if (bid >= highestBid)
                {
                    lblCurrent.Text = "Current Bid: $" + bid;
                    MessageBox.Show("You won the auction for " + bid + " dollars!");
                }
                else
                {
                    lblCurrent.Text = "Current Bid: $" + highestBid;
                    MessageBox.Show("You lost the auction. The winner bid $" + highestBid + " but your bid was only $" +
                                    bid);
                }
            }
            catch (SystemException)
            {
                MessageBox.Show("Invalid values entered");
            }

            
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void btnBid_Click(object sender, EventArgs e)
        {
            string text1 = txtBid.Text;
            int num1;
            double num2;
            bool res = int.TryParse(text1, out num1);
            bool res2 = double.TryParse(text1, out num2);
            if (res)
            {
                AcceptBid(num1);
            } else if (res2)
            {
                AcceptBid(num2);
            }
            else
            {
                var myBid = txtBid.Text;
                AcceptBid(myBid);
            }
            
        }
    }


}
