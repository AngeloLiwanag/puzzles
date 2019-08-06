using System;
using System.Collections.Generic;
namespace puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            // randomArray(arr);
            // System.Console.WriteLine(TossCoin());
            Names();
        }
        
        public static void randomArray(int[] arr)
        {
            
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                arr[i] = rand.Next(5, 26);
            }
            int min = arr[0];
            int max = arr[0];
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                sum += arr[i];
            }
            
            System.Console.WriteLine(min);
            System.Console.WriteLine(max);
            System.Console.WriteLine(sum);
        }

        public static string TossCoin()
        {
            System.Console.WriteLine("Tossing a Coin");
            Random rand = new Random();
            int coin = rand.Next(1,3);
            if(coin % 2 != 0)
            {
                return $"Heads";
            } else {
                return $"Tails";
            }
        }

        public static void Names()
        {
            List<string> longNames = new List<string>();
            List<string> names = new List<string>();
            names.Add("Todd");
            names.Add("Tiffany");
            names.Add("Chairle");
            names.Add("Geneva");
            names.Add("Sydney");

            Random rand = new Random();
            for (int i = 0; i < names.Count; i++)
            {
                int idx = rand.Next(0, 5);
                System.Console.WriteLine(names[idx]);
                if (names[idx].Length > 5)
                {
                    longNames.Add(names[idx]);
                }
            }

            for (int i = 0; i < longNames.Count; i++)
            {
                System.Console.WriteLine("Names greater than 5: " + longNames[i]);
            }

        }
        
    }
}
