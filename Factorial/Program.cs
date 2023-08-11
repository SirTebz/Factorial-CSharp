using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Prompt
            Console.Write("Number: ");
            string sPrompt = Console.ReadLine();
            
            int iNum;            
            if (int.TryParse(sPrompt,out iNum))
            {
                int iFact = Factorial(iNum); //with a loop
                //int iFact = Fact(iNum); //with a recursion
                Console.WriteLine("The factorial of {0} is {1}",iNum, iFact);
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }


            Console.Write("\nPress any key to exit...");
            Console.ReadKey();
        }

        //With a Loop
        public static int Factorial(int iNum)
        {
            int iProd = 1;
            for (int i = 1; i <= iNum; i++)
            {
                iProd = iProd * i;
            }
            return iProd;
        }

        //With Recursion
        public static int Fact(int iNum)
        {
            if (iNum > 1)
            {
                return iNum * Fact(iNum - 1);
            }
            else
            {
                return 1;
            }
        }
    }
}
