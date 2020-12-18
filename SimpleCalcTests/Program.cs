using System;
using SimpleCalc;

namespace ClassUnitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleCalcTests test = new SimpleCalcTests();
            Console.WriteLine("Start Tests!");
            Console.WriteLine("plus testing...");
            if(test.plusTest())
            {
                Console.WriteLine("plus testing ->passed");
            }
            else
            {
                Console.WriteLine("plus testing ->error");
            }
            Console.WriteLine("");

            Console.WriteLine("minus testing...");
            if (test.minusTest())
            {
                Console.WriteLine("minus testing ->passed");
            }
            else
            {
                Console.WriteLine("minus testing ->error");
            }
            Console.WriteLine("");

            Console.WriteLine("multi testing...");
            if (test.multiTest())
            {
                Console.WriteLine("multi testing ->passed");
            }
            else
            {
                Console.WriteLine("multi testing ->error");
            }
            Console.WriteLine("");

            Console.WriteLine("divide testing...");
            if (test.divideTest())
            {
                Console.WriteLine("divide testing ->passed");
            }
            else
            {
                Console.WriteLine("divide testing ->error");
            }
            Console.WriteLine("");

            Console.WriteLine("select plus testing...");
            if (test.selectionPlusTest())
            {
                Console.WriteLine("select plus testing ->passed");
            }
            else
            {
                Console.WriteLine("select plus testing ->error");
            }
            Console.WriteLine("");

            Console.WriteLine("select minus testing...");
            if (test.selectionMinusTest())
            {
                Console.WriteLine("select minus testing ->passed");
            }
            else
            {
                Console.WriteLine("select minus testing ->error");
            }
            Console.WriteLine("");

            Console.WriteLine("select multi testing...");
            if (test.selectionMultiTest())
            {
                Console.WriteLine("select multi testing ->passed");
            }
            else
            {
                Console.WriteLine("select multi testing ->error");
            }
            Console.WriteLine("");

            Console.WriteLine("select divide testing...");
            if (test.selectionDivideTest())
            {
                Console.WriteLine("select divide testing ->passed");
            }
            else
            {
                Console.WriteLine("select divide testing ->error");
            }
            Console.WriteLine("");

            Console.WriteLine("select divde by zero testing...");
            if (test.selectionDivideByZeroTest())
            {
                Console.WriteLine("select divde by zero testing ->passed");
            }
            else
            {
                Console.WriteLine("select divde by zero testing ->error");
            }
            Console.WriteLine("");



        }
    }
}
