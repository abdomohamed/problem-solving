using System;
using System.Collections.Generic;
using System.Globalization;

namespace ACM
{
    public class TwoGangsters
    {
        public static void Run()
        {
            string input = Console.In.ReadToEnd();
            string[] inputData = input.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int numberOfOrders = Int32.Parse(inputData[0]);
            int numberSteaks = Int32.Parse(inputData[1]);
            if (numberOfOrders < numberSteaks)
            {
                Console.WriteLine("{0}", 2);
                return;
            }
            
            if (numberOfOrders*2%numberSteaks != 0)
            {
                Console.WriteLine("{0}", (numberOfOrders * 2 / (numberSteaks)) + 1);
            }
            else
            {
                Console.WriteLine("{0}", numberOfOrders * 2 / (numberSteaks));
            }
        }
    }
}
