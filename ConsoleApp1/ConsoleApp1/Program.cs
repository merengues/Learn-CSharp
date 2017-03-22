using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] myArray;
            myArray = new bool[15];
            myArray[4] = true;

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]+"***"+myArray[i].GetType().ToString());
            }

            int[] heights;
            heights = new int[7];
            heights[0] = 68;
            heights[1] = 70;
            heights[2] = 63;
            heights[3] = 60;
            heights[4] = 58;
            heights[5] = 72;
            heights[6] = 74;


            Console.ReadLine();
        }

        class Menumaker
        {
            public Random Randomizer;
            string[] Meats = { "Roast beaf", "Salami", "Turkey", "Ham", "Pastrami" };
            string[] Condiments = { "yellow mustard", "brown mustard", "honey mustard", "mayo", "relish", "french dressing" };
            string[] Breads = { "rye", "white", "wheat", "pumpernickel", "italian bread", "a roll" };

            public string GetMenuItem()
            {
                string randomMeat = Meats[Randomizer.Next(Meats.Length)];
                string randomCondiments = Condiments[Randomizer.Next(Condiments.Length)];
                string randomBread = Breads[Randomizer.Next(Breads.Length)];
                return randomMeat + " with " + randomCondiments + " with " + randomBread;
            }
        }
    }
}
