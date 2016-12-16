using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Tasks12_16_2016
{
    class Triangles
    {
        public Triangles()
        {

        }
        public int NumberPerSide { get; set; }

        public void Triangle(int number)
        {
            int input = number;
            string star = "*";
            for (int i = 0; i < input; i++)
            {
                Console.WriteLine(star);
                star += "*";
            }
            Console.WriteLine("\n{0} sided triangle!", number);
            Console.ReadLine();
        }

        public void HalfDiamond(int number)
        {
            int input = number;
            string star = "*";
            for (int i = 0; i < input; i++)
            {
                Console.WriteLine(star);
                star += "*";                  
            }
            for (int i = number - 1; i > 0 ; i--)
            {
                for (int j = 0 ; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        public void ReverseTriangle(int number)
        {
            for(int i = 0; i < number;i++)
            {
                for (int j = 0; j < number - i; j++)
                    Console.Write(" ");
                for (int j = 0; j <= i; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
        public bool PalindromeChecker(string input)
        {
            input = Regex.Replace(input, @"[\W_]", string.Empty);
            char[] characters = input.ToCharArray();
            char[] flipChar = new char[input.Length];
            int counter = 0;
            for (int i = 0; i < flipChar.Length; i++)
            {
                flipChar[i] = characters[(input.Length - 1) - i];
            }
            for (int i = 0; i < input.Length; i++)
            {
                if(flipChar[i] == characters[i])
                {
                    counter++;
                }
            }
           return counter == input.Length ?  true :  false;
        }
    }
}
