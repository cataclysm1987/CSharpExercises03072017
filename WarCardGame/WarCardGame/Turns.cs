using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WarCardGame.RandomExtensions;

namespace WarCardGame
{
    public class Turns
    {
        public int CurrentDraw { get; set; }
        public int[] DeckArray { get; set; }
        public int PlayerOneScore { get; set; }
        public int PlayerTwoScore { get; set; }


        public Turns()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52 };
            
            int[] shuffle = RandomizeInts(array);
            Shuffle(shuffle);
            CurrentDraw = 0;
            DeckArray = shuffle;
        }

        ~Turns()
        {
            
        }
        public string CheckCardName(int arrayvalue)
        {
            Dictionary<int, string> deck = new Dictionary<int, string>
            {
                {1, "Ace of Spades"},
                {2, "Ace of Clubs"},
                {3, "Ace of Hearts"},
                {4, "Ace of Diamonds"},
                {5, "Two of Spades"},
                {6, "Two of Clubs"},
                {7, "Two of Hearts"},
                {8, "Two of Diamonds"},
                {9, "Three of Spades"},
                {10, "Three of Clubs"},
                {11, "Three of Hearts"},
                {12, "Three of Diamonds"},
                {13, "Four of Spades"},
                {14, "Four of Clubs"},
                {15, "Four of Hearts"},
                {16, "Four of Diamonds"},
                {17, "Five of Spades"},
                {18, "Five of Clubs"},
                {19, "Five of Hearts"},
                {20, "Five of Diamonds"},
                {21, "Six of Spades"},
                {22, "Six of Clubs"},
                {23, "Six of Hearts"},
                {24, "Six of Diamonds"},
                {25, "Seven of Spades"},
                {26, "Seven of Clubs"},
                {27, "Seven of Hearts"},
                {28, "Seven of Diamonds"},
                {29, "Eight of Spades"},
                {30, "Eight of Clubs"},
                {31, "Eight of Hearts"},
                {32, "Eight of Diamonds"},
                {33, "Nine of Spades"},
                {34, "Nine of Clubs"},
                {35, "Nine of Hearts"},
                {36, "Nine of Diamonds"},
                {37, "Ten of Spades"},
                {38, "Ten of Clubs"},
                {39, "Ten of Hearts"},
                {40, "Ten of Diamonds"},
                {41, "Jack of Spades"},
                {42, "Jack of Clubs"},
                {43, "Jack of Hearts"},
                {44, "Jack of Diamonds"},
                {45, "Queen of Spades"},
                {46, "Queen of Clubs"},
                {47, "Queen of Hearts"},
                {48, "Queen of Diamonds"},
                {49, "Queen of Spades"},
                {50, "Queen of Clubs"},
                {51, "Queen of Hearts"},
                {52, "Queen of Diamonds"}
            };

            string result;
            deck.TryGetValue(arrayvalue, out result);
            return result;
        }
        public int GetCardValue(int arrayvalue)
        {
            if (arrayvalue <= 4)
            {
                return 13;
            } else if (arrayvalue <= 8)
            {
                return 1;
            }
            else if (arrayvalue <= 12)
            {
                return 2;
            }
            else if (arrayvalue <= 16)
            {
                return 3;
            }
            else if (arrayvalue <= 20)
            {
                return 4;
            }
            else if (arrayvalue <= 24)
            {
                return 5;
            }
            else if (arrayvalue <= 28)
            {
                return 6;
            }
            else if (arrayvalue <= 32)
            {
                return 7;
            }
            else if (arrayvalue <= 36)
            {
                return 8;
            }
            else if (arrayvalue <= 40)
            {
                return 9;
            }
            else if (arrayvalue <= 44)
            {
                return 10;
            }
            else if (arrayvalue <= 48)
            {
                return 11;
            }
            else if (arrayvalue <= 52)
            {
                return 12;
            }
            else
            {
                return 0;
            }
        }

        public string GetWinner()
        {
            if (PlayerOneScore > PlayerTwoScore)
            {
                return "Player 1 Wins!";
            } else if (PlayerTwoScore > PlayerOneScore)
            {
                return "Player 2 Wins!";
            }
            else
            {
                return "It's a tie!";
            }
        }

        public string PlayTurn(int[] intarray)
        {
            string message;
            if (CurrentDraw == 52)
            {
                message = "Game over! " + GetWinner();
            }
            else
            {
                try
                {


                    message = "Player 1 draws a " + CheckCardName(intarray[(CurrentDraw)]) + " and player 2 draws a " +
                              CheckCardName(intarray[CurrentDraw + 1]) + ". ";
                    if (GetCardValue(intarray[CurrentDraw]) > GetCardValue(intarray[CurrentDraw + 1]))
                    {
                        message += "Player 1 wins the draw and gets 2 points! ";
                        PlayerOneScore += 2;
                    }
                    else if (GetCardValue(intarray[CurrentDraw + 1]) > GetCardValue(intarray[CurrentDraw]))
                    {
                        message += "Player 2 wins the draw and gets 2 points! ";
                        PlayerTwoScore += 2;
                    }
                    else
                    {
                        message += "It's a tie. No points awarded!";
                    }
                    CurrentDraw += 2;
                    if (CurrentDraw == 51)
                    {
                        message += "Game over! " + GetWinner();
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    message = "Game over! " + GetWinner();
                }
            }
            return message;

        }
    }

    
}
