using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solving_Problems
{
    public static class BicycleCodes
    {
        public static void Run()
        {
            string input = Console.In.ReadToEnd();
            string[] numbers = input.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int thiefNumber = 0;

            int lock1 = Int32.Parse(numbers[0]);
            int lock2 = Int32.Parse(numbers[1]);

            if (lock1 == lock2)
                Console.WriteLine("yes");
            else
            {
                Console.WriteLine(lock1 % 2 == 0 || lock2 % 2 == 1 ? "yes" : "no");
            }

        }
    }
}
