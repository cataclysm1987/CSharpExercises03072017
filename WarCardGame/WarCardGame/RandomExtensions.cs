using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarCardGame
{
    public static class RandomExtensions
    {

        public static void Shuffle<T>(T[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n; i++)
            {
                // NextDouble returns a random number between 0 and 1.
                // ... It is equivalent to Math.random() in Java.
                int r = i + (int)(_random.NextDouble() * (n - i));
                T t = array[r];
                array[r] = array[i];
                array[i] = t;
            }
        }


        public static void Shuffle<T>(this Random rng, T[] array)
        {
            int n = array.Length;
            while (n > 1)
            {
                int k = rng.Next(n--);
                T temp = array[n];
                array[n] = array[k];
                array[k] = temp;
            }
        }

        static Random _random = new Random();

        public static int[] RandomizeInts(int[] arr)
        {
            List<KeyValuePair<int, int>> list =
                new List<KeyValuePair<int, int>>();
            // Add all strings from array.
            // ... Add new random int each time.
            foreach (int s in arr)
            {
                list.Add(new KeyValuePair<int, int>(_random.Next(), s));
            }
            // Sort the list by the random number.
            var sorted = from item in list
                         orderby item.Key
                         select item;
            // Allocate new string array.
            int[] result = new int[arr.Length];
            // Copy values to array.
            int index = 0;
            foreach (KeyValuePair<int, int> pair in sorted)
            {
                result[index] = pair.Value;
                index++;
            }
            // Return copied array.
            return result;
        }

        //static void Main()
        //{
        //    int[] arr = new int[]
        //    {
        //    "cat",
        //    "animal",
        //    "abacus",
        //    "framework"
        //    };
        //    int[] shuffle = RandomizeInts(arr);
        //    foreach (string s in shuffle)
        //    {
        //        Console.WriteLine(s);
        //    }
        //}
    }
}
