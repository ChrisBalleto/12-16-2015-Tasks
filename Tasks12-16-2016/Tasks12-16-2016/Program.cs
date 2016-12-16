using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks12_16_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangles Test = new Triangles();


            Console.WriteLine(Test.PalindromeChecker("r*()&  ace     car"));

            Console.ReadLine();

            Test.ReverseTriangle(5);

            Console.ReadLine();

            Test.Triangle(18);

            Console.ReadLine();

            Test.HalfDiamond(25);

            Console.ReadLine();

        }
    }
}
