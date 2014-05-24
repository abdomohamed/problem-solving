using System;

namespace ACM
{
    public static class Eniya
    {
        public static void Run()
        {
            string input = Console.In.ReadToEnd();
            string[] numbers = input.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int output = 1;

            foreach (var number in numbers)
            {
                output *= Int32.Parse(number);
            }

            output *= 2;

            Console.WriteLine(output);
        }
    }
}