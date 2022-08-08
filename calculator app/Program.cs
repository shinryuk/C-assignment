using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class program
    {
        public static void addition(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("addition result is  {0}",  result) ;
        }
        public static void Substraction(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("Sbstraction result is  {0}", result);
        }
        public static void Division(int a, int b)
        {
            int result = a / b;
            Console.WriteLine("Division result is  {0}", result);
        }
        public static void Multiplication(int a, int b)
        {
            int result = a * b;
            Console.WriteLine("Multiplication result is  {0}", result);
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("enter 1 number");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter Second number");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter operator (+, -, / * )");
            string op = Console.ReadLine();

            if (op.Equals("+"))
            {
                program.addition(n1, n2);
            }
            else if (op.Equals("-"))
            {
                program.Substraction(n1, n2);
            }
            else if (op.Equals("/"))
            {
                program.Division(n1, n2);
            }
            else if (op.Equals("*"))
            {
                program.Multiplication(n1, n2);
            }
            else
            {
                Console.WriteLine("invalid input");
            }
            Console.ReadLine();
        }
    }
}