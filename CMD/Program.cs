using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Параметри
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 3)
            {
                Console.WriteLine();
                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine("x : множення");
                Console.WriteLine("/ : ділення");
                Console.WriteLine("+ : додавання");
                Console.WriteLine("- : віднімання");
                Console.OutputEncoding = Encoding.Default;
                int num1 = int.Parse(args[0]);
                char ch = char.Parse(args[1]);
                int num2 = int.Parse(args[2]);
                switch (ch)
                {
                    case 'x':
                        Console.WriteLine(num1 * num2);
                        break;
                    case '/':
                        Console.WriteLine(num1 / num2);
                        break;
                    case '+':
                        Console.WriteLine(num1 + num2);
                        break;
                    case '-':
                        Console.WriteLine(num1 - num2);
                        break;
                    default: break;
                }
            }
            else
            {
                Console.WriteLine("Помилковий ввід");
            }
        }
    }
}