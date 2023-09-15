using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DubrovinSN.Sprint0.Task5.V0.Lib;
namespace Tyuiu.DubrovinSN.Sprint0.Task5.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A + B = " + DataService.Addition(5, 9));
            Console.WriteLine("A - B = " + DataService.Substracrion(100, 90));
            Console.WriteLine("A * B = " + DataService.Multiplication(9, 9));
            Console.WriteLine("A / B = " + DataService.Division(45, 5));
            Console.ReadKey();
        }
    }
}
