using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solving_Problems
{
    public class TitanRuins
    {
        public static void Run()
        {
            string input = Console.In.ReadToEnd();
            string[] inputData = input.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int numberOfSections = Int32.Parse(inputData[0]);
            
            int consecutiveMiddle = -1;

            int maxSum = 0;

            for (int index = 1; index <= numberOfSections - 2; index++)
            {
                int currentSection = Int32.Parse(inputData[index]);
                int consec_middle_Section = Int32.Parse(inputData[index + 1]);
                int consec_last_Section = Int32.Parse(inputData[index + 2]);


                int sum = currentSection + consec_middle_Section + consec_last_Section;

                if (sum > maxSum)
                {
                    maxSum = sum;
                    consecutiveMiddle = index + 1;
                }
            }

            Console.WriteLine("{0} {1}", maxSum, consecutiveMiddle);
        }

        
    }
}