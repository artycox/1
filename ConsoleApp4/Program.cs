using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            for (; ; )
            {
                i++;
                double dollarCOurse = 2.13;
                double euroCOurse = 2.43;
                double jpyCOurse = 0.019;
                Console.Write("\n1-Доллар \n2-Евро \n3-Йены");
                string s;
                Console.Write("\nВыберите Валюту и нажмите Enter");
                s = Console.ReadLine();
                Console.WriteLine(s);
                string a;
                Console.Write("Введите сумму:");
                double inputSum = Convert.ToDouble(a = Console.ReadLine());

                Console.WriteLine(a);
                switch (s)
                {
                    case "1":
                        Console.WriteLine(inputSum * dollarCOurse);
                        break;
                    case "2":
                        Console.WriteLine(inputSum * euroCOurse);
                        break;
                    case "3":
                        Console.WriteLine(inputSum * jpyCOurse);
                        break;

                }

            }
        }
    }
}

