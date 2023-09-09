using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGit
{
    
    internal class Program
    {
        static int Func(int x)
        {
            x = (int)Math.Pow(x, 2);
            return x;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("test github");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{a} * {a} = {Func(a)}");

            Console.ReadLine();
        }
    }
}
