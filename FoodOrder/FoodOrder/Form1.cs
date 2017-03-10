using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodOrder
{
    public partial class Form1 : Form
    {
        public double enchilada = 2.95;
        public double burrito = 1.95;
        public double taco = 1.25;
        public double tostada = 3.95;
        public double chickenquesadilla = 4.95;
        public double steakquesadilla = 6.95;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int enchnum = 0;
            int burrnum = 0;
            int taconum = 0;
            int tostadanum = 0;
            int chickenquesnum = 0;
            int steakquesnum = 0;

            Int32.TryParse(comboBox1.Text, out enchnum);
            Int32.TryParse(comboBox2.Text, out burrnum);
            Int32.TryParse(comboBox3.Text, out taconum);
            Int32.TryParse(comboBox4.Text, out tostadanum);
            Int32.TryParse(comboBox5.Text, out chickenquesnum);
            Int32.TryParse(comboBox6.Text, out steakquesnum);

            double enchdouble = enchnum * enchilada;
            double burrdouble = burrnum * burrito;
            double tacodouble = taconum * taco;
            double tostadadouble = tostadanum * tostada;
            double chickenquesdouble = chickenquesnum * chickenquesadilla;
            double steakquesdouble = steakquesnum * steakquesadilla;

            double total = enchdouble + burrdouble + tacodouble + tostadadouble + chickenquesdouble + steakquesdouble;

            lblOrder.Text = "Order Total: " + total.ToString("C");
        }
    }
}
