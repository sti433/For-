using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication63
{
    class Program
    {
        static void Main(string[] args)
        {
             float a, sum, s;
             for (int i = 1; i <= 10; i++)
             {
                 s = 0;
                 for (int b = 1; b <= 5; b++)
                 {
                     a = float.Parse(Console.ReadLine());
                     s = s + a;
                     sum = s / 5;
                 }
                 sum = 0;
                 //sum = s/ 5;
                 Console.WriteLine(sum);
             }
                Console.ReadKey();





        }
    }
}
