using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            var (numbers, operations) = ParseMathExpression(expression);
            ShowList(numbers);
            ShowList(operations);
            Console.ReadKey();
        }

        static (List<int>, List<string>) ParseMathExpression(string expression)
        {
            expression = expression.Replace(" ", "");
            List<int> numbers = new List<int>();
            List<string> operations = new List<string>();
            int currentNumber = 0;
            foreach (char c in expression)
            {
                if (char.IsDigit(c))
                {
                    currentNumber = currentNumber * 10 + (c - '0');
                }
                else
                {
                    numbers.Add(currentNumber);
                    currentNumber = 0;
                    operations.Add(c.ToString());
                }
            }
            numbers.Add(currentNumber);
            return (numbers, operations);
        }

        static void ShowList<T>(List<T> list)
        {
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
