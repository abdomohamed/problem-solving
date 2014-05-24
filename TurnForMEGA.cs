using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solving_Problems
{
    public class TurnforMEGA
    {
        public static void Run()
        {
            string input = Console.In.ReadLine();
            string[] inputData = input.Split(new char[] {' ', '\t', '\n', '\r'}, StringSplitOptions.RemoveEmptyEntries);

            int numberOfCarsPassPerMinute = Int32.Parse(inputData[0]);
            int numberOfMinutes = Int32.Parse(inputData[1]);

            input = Console.In.ReadLine();

            var numbersOfCasrsPerminute = input.Split(new char[] {' ', '\t', '\n', '\r'},
                                                      StringSplitOptions.RemoveEmptyEntries);
            int waitingCars = 0;
            int remainingCars = 0;
            int index = 0;

            foreach (var carsWaitingInMinute in numbersOfCasrsPerminute)
            {
                int numberOfCarsWaiting = Int32.Parse(carsWaitingInMinute);

                numberOfCarsWaiting += remainingCars;
                remainingCars = 0;

                int diff = numberOfCarsWaiting - numberOfCarsPassPerMinute;

                index++;

                if (diff < 0) continue;

                remainingCars = diff;


                if (index == numberOfMinutes)
                {
                    waitingCars = remainingCars;
                }
            }

            Console.WriteLine("{0}", waitingCars);
        }
    }
}
