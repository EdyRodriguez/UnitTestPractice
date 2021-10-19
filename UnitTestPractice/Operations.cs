using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestPractice
{
    public class Operations
    {
        public  double DoOperation(int  [] num , string [] operation)
        {
            
            if(num.Length <= operation.Length || num.Length > operation.Length+1)
            {
                Console.WriteLine("Ingresa unos arreglos validos");
                return 0;
            }
            else
            {
                double result = 0;
                double num1;
                int counter = 1;
                for (int i = 0; i < operation.Length; i++, counter++)
                {

                    if (i == 0)
                    {
                        result = num[0];

                        num1 = num[counter];

                    }
                    else
                    {
                        num1 = num[counter];
                    }

                    switch (operation[i])
                    {
                        case "+":
                            result += num1;
                            break;
                        case "-":
                            result -= num1;
                            break;
                        case "*":
                            result *= num1;
                            break;
                        case "/":
                            result /= num1;
                            break;
                        default:
                            Console.WriteLine("Introduce una operación valida");
                            return 0;

                    }
                }
                return result;
            }
            
        }
    }
}
