using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solving_Problems
{
    public class Workdays
    {
        public static void Run()
        {
            string input = Console.In.ReadToEnd();
            string[] inputData = input.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int n = Int32.Parse(inputData[0]);
            int m = Int32.Parse(inputData[1]);

            Console.WriteLine(n * (m + 1));
        }

    }
}