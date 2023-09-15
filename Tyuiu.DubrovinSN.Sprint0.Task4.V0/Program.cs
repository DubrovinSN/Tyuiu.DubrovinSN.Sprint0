using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DubrovinSN.Sprint0.Task4.V0.Lib;

namespace Tyuiu.DubrovinSN.Sprint0.Task4.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.Multiplication(6, 3));
            Console.WriteLine(DataService.Division(6, 3));
            Console.WriteLine(DataService.Addition(6, 3));
            Console.WriteLine(DataService.Substracrion(6, 3));
            Console.ReadKey();
        }
    }
}
