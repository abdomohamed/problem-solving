using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solving_Problems
{
    public class PsychUpsEigenvalues
    {
        public static void Run()
        {
            string input = Console.In.ReadToEnd();
            string[] inputData = input.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int index = 0;
            var numbersSimiliraties = new Dictionary<string, int>();
            int numberOfSets = 0;

            do
            {
                int numberOfItems = Int32.Parse(inputData[index]);

                for (int next = index + 1; next <= index + numberOfItems;  next++)
                {
                    string currentNumber = inputData[next];

                    if (numbersSimiliraties.ContainsKey(currentNumber))
                    {
                        numbersSimiliraties[currentNumber]++;
                    }
                    else
                    {
                        numbersSimiliraties[currentNumber] = 1;
                    }
                }

                numberOfSets++;
                index = index + numberOfItems + 1;

            } while (index < inputData.Length);

            int countOfEigenValues = 0;

            foreach (var numbersSimiliraty in numbersSimiliraties)
            {
                if (numbersSimiliraty.Value == numberOfSets)
                {
                    countOfEigenValues++;
                }
            }
            
            Console.WriteLine(countOfEigenValues);
        }
    }
}
