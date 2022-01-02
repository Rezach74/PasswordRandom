using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.Csharp.Part1.RandomPassword
{
    class Password : IPasswordRepository
    {
        public void Show()
        {
            Console.WriteLine("Enter a Number:");
            Number =int.Parse( Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Your Password is{_Number}");   
        }

        public void Create()
        {
            Random rn = new Random(5);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            List<int> rnlist = new List<int>();
            for (int i = 1; i < 10; i++)
            {
                rnlist.Add(rn.Next(10000,99999));
            }
            foreach (int item in rnlist)
            {
                Console.WriteLine(item);
            }
          
        }

        private int _Number;
        public int Number {
            get{
                return _Number;
            }
            set {
                if (value==null)
                {
                    Console.WriteLine("Error NullNumber!");
                }
                else
                {
                    _Number = value;
                }
            }
        }

         
    }
    }
