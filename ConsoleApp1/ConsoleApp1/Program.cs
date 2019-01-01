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
            int selection ;
            Console.WriteLine(" Enter Numbers : ");
            selection = Convert.ToInt16(Console.ReadLine());

            switch (selection)
            {
                case 1:
                    Console.WriteLine("Vowel");
                    break;
                case 2:
                    Console.WriteLine("Vowel");
                    break;
                default:
                    Console.WriteLine("Not a vowel");
                    break;
            }
        }
    }
}
