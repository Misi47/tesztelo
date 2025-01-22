using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doga
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adj meg két számot!");
            Console.Write("Első szám: ");
            int sz1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Második szám: ");
            int sz2 = Convert.ToInt32(Console.ReadLine());
           

            Console.WriteLine("Írd be a kívánt műveletet(+-*/)");
            string muv = Console.ReadLine();
            if (muv=="+"|| muv == "-" || muv == "*" || muv == "/") 
            {
                if (muv == "+")
                {
                    Console.WriteLine($"A két szám összege:" + (sz1 + sz2));
                }
                else if (muv == "-")
                {
                    Console.WriteLine($"A két szám különbsége:" + (sz1 - sz2));
                }
                else if (muv == "*")
                {
                    Console.WriteLine($"A két szám szorzata:" + (sz1 * sz2));
                }
                else if (muv == "/")
                {
                    if (sz2 == 0)
                    {
                        Console.WriteLine("Nullával nem lehet osztani");
                    }
                    else
                    {
                        Console.WriteLine($"A két szám hányadosa:" + (sz1 / sz2));
                    }

                }
            }
            else 
            {
                Console.WriteLine("Nem érvényes műveletet adtál meg");
            }
            
            Console.ReadKey();
        }
    }
}
