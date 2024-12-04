using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dogaa
{
    class Program
    {
        static void Main(string[] args)
        {
            int mostaniev =2024;
            Console.WriteLine("Add meg az évet amikor nyert");
            string ev = Console.ReadLine();
            int szam;
            bool szame = int.TryParse(ev, out szam);

            if (szame)
            {
                Console.WriteLine($"{ev} egy szám");
            }
            else
            {
                Console.WriteLine($"{ev} nem egy szám");
            }



            Console.WriteLine("Add meg  a nevét");
            string nev = Convert.ToString(Console.ReadLine());
   

            Console.WriteLine("Add meg a születési és halálozási évet");
            string szulhalev = Console.ReadLine();


            if (szulhalev.Length == 9 && szulhalev[4] == '-')
            {
                Console.WriteLine("Jól írtad be");
            }
            else
            {
                Console.WriteLine("Rosszul írtad be");
            }


            int ev2 = Convert.ToInt32(ev);
            int kul= mostaniev - ev2;
            Console.WriteLine($"{kul} éve kapta meg a nobel díjat");

            Console.WriteLine("Add meg milyen nemzetiségű");
            string orszag = Console.ReadLine();

            if(orszag=="")
            {
                Console.WriteLine("Nem adtál meg adatot");
            }
            else
            {
                Console.WriteLine("Adtál meg adatot");
            }
       

            Console.ReadKey();
        }
    }
}
