using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Series
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("\"Fibonacci Series\"");
                int n1 = 0, n2 = 1, i, number;
                Console.WriteLine("Enter the number (where number > 2): ");
                number = int.Parse(Console.ReadLine());
                Console.Write(n1 + ", " + n2 + ", ");
                for (i = 2; i < number; ++i)
                {
                    int n3;
                    n3 = n1 + n2;
                    Console.Write(n3 + ", ");
                    n1 = n2;
                    n2 = n3;
                }
                Console.ReadLine();
            }
        }
    }
