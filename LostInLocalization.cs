using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solving_Problems
{
    public static class LostInLocalization
    {
        public static void Run()
        {
            NumberFormatInfo nfi = NumberFormatInfo.InvariantInfo;
            string input = Console.In.ReadToEnd();
            string[] numbers = input.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            var boundries = new Dictionary<int, string> { { 4, "few" }, { 9, "several" }, { 19, "pack" }, { 49 , "lots"},
                                                            {99, "horde"}, {249, "throng"}, {499, "swarm"},{999, "zounds"} , {1000, "legion"} };

            foreach (var number in numbers)
            {
                int currentNumber = int.Parse(number);

                foreach (var boundry in boundries.Keys)
                {
                    string word = "";

                    if (currentNumber > 1000)
                    {
                        word = boundries[1000];
                    }
                    else
                    {
                        if (currentNumber <= boundry)
                        {
                            word = boundries[boundry];
                        }
                    }

                    if (!string.IsNullOrEmpty(word))
                    {
                        Console.WriteLine(word);
                        break;
                    }
                }
            }

        }
    }
}
