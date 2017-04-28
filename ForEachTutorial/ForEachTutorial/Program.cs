using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = "";
            Console.Write("Enter a city:");
            string city = Console.ReadLine();

            char[] cityArray = city.ToArray();
            Array.Reverse(cityArray);

            foreach (char item in cityArray)
            {
                result = result + item;
            }
            Console.Write("Reversed value: {0}",result);

            Console.ReadLine();
        }
    }
}
