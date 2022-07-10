using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsWithLoopsAndConditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LukeWarm Section
            PrintNumbers();

            // Write a method that will print to the console all numbers 1000 through -1000 =====================
            public static void PrintNumbers()
            {
                for(int a = 1000; a >= -1000; a--)
                {
                    Console.WriteLine(a);
                }
            }
            // Write a method that will print to the console numbers 3 through 999 by 3 each time ===============

            // Write a method to accept two integers as parameterss and check whether they are equal or not =====

            // Write a method to check whether a given number is even or odd ====================================

            // Write a method to check whether a given number is positive or negative ===========================

            // Write a method to read the age of a candidate and determine whether they can vote. ===============

            #endregion
            #region Getting Warm Section
            // Write a method to check if an integer (from the user) is in the range -10 to 10 ==================

            int i, num;
            // Write a method to display the multiplication table (from 1 to 12) of a given integer =============
            Console.WriteLine("Enter number to print a Multiplication table: ");
            num = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= 12; i++)
            {         
                Console.Write("{0} X {1} = {2} \n", num, i, num * i);
            }
            #endregion
        }
    }
}
