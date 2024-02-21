using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значения параметра x = ");
            string S = Console.ReadLine();
            double x = Convert.ToDouble(S);
            double F = (Math.Sin(x) + Math.Cos(x))/2;
            Console.WriteLine($"Для значения x = {x}, F = {F}.");
        }
    }
}
