using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solving_Problems
{
    public class LonesomeKnight
    {
        public static void Run()
        {
            string input = Console.In.ReadToEnd();
            string[] inputData = input.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int numberOfCases = Int32.Parse(inputData[0]);

            for (int index = 1; index <= numberOfCases; index++)
            {
                int numberOfSquarseUnderAttack = LonesomeKnight.NumberSquaresUnderAttack(inputData[index]);
                Console.WriteLine(numberOfSquarseUnderAttack);
            }
        }

        public static int NumberSquaresUnderAttack(string postion)
        {
            int col = ((int)postion[0] - 97) + 1;
            int row = Int32.Parse(postion[1].ToString());

            int countOfUnderAttackSquares = 0;

            int postion_row_1 = row + 2, postion_row_2 = row - 2;
            int position_col_1 = col + 1, position_col_2 = col - 1;

            if (isValidPosition(postion_row_1, position_col_1)) countOfUnderAttackSquares++;
            if (isValidPosition(postion_row_1, position_col_2)) countOfUnderAttackSquares++;

            if (isValidPosition(postion_row_2, position_col_1)) countOfUnderAttackSquares++;
            if (isValidPosition(postion_row_2, position_col_2)) countOfUnderAttackSquares++;

            position_col_1 = col + 2;
            position_col_2 = col - 2;

            postion_row_1 = row + 1;
            postion_row_2 = row - 1;

            if (isValidPosition(postion_row_1, position_col_1)) countOfUnderAttackSquares++;
            if (isValidPosition(postion_row_2, position_col_1)) countOfUnderAttackSquares++;

            if (isValidPosition(postion_row_1, position_col_2)) countOfUnderAttackSquares++;
            if (isValidPosition(postion_row_2, position_col_2)) countOfUnderAttackSquares++;

            return countOfUnderAttackSquares;
        }

        public static bool isValidPosition(int row, int col)
        {
            if ((row >= 1 && row <= 8) && (col <= 8 && col >= 1))
            {
                return true;
            }
            return false;
        }
    }
}