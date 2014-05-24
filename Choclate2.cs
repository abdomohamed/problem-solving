using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solving_Problems
{
    public static class Choclate2
    {
        public static void Run()
        {
            string input = Console.In.ReadToEnd();
            string[] numbers = input.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = Int32.Parse(numbers[0]);
            int columns = Int32.Parse(numbers[1]);

            Console.WriteLine( rows * columns % 2 == 0 ? "[:=[first]" : "[second]=:]");

        }

        public static void Main()
        {
            Choclate2.Run();
        }

    }
}
