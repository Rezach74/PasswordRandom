using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.Csharp.Part1.RandomPassword
{
    class Program
    {
        static void Main(string[] args)
        {
            Password password = new Password();
            password.Show();
            password.Create();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Any Key For Exit...");
            Console.ReadKey();
        }
    }
}
