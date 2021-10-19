using System;

namespace UnitTestPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var op = new Operations();
            int[] array = { 5, 4, 3, 2 };
            string[] arrays = new string[] { "+", "*", "/" };
            var result = op.DoOperation(array, arrays );
            Console.WriteLine(result);
        }
    }
}
