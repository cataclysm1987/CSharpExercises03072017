using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WarCardGame.RandomExtensions;

namespace WarCardGame
{

    public partial class Form1 : Form
    {

        Turns game = new Turns();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Reuse ctor method and reset score
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52 };
            
            int[] shuffle = RandomizeInts(array);
            Shuffle(shuffle);
            game.CurrentDraw = 0;
            game.DeckArray = shuffle;
            game.PlayerOneScore = 0;
            game.PlayerTwoScore = 0;
            //Update label with playturn method
            label1.Text = game.PlayTurn(game.DeckArray);
            label2.Text = "Player 1 Score: " + game.PlayerOneScore;
            label3.Text = "Player 2 Score: " + game.PlayerTwoScore;
            label4.Text = "Cards Dealt: " + game.CurrentDraw;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = game.PlayTurn(game.DeckArray);
            label2.Text = "Player 1 Score: " + game.PlayerOneScore;
            label3.Text = "Player 2 Score: " + game.PlayerTwoScore;
            label4.Text = "Cards Dealt: " + game.CurrentDraw;
        }
    }
}
