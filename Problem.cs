using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solving_Problems
{
    public class ProblemUtils
    {
        public static string[] ReaData()
        {
            string input = Console.In.ReadToEnd();
            string[] inputData = input.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            return inputData;
        }
    }
}
