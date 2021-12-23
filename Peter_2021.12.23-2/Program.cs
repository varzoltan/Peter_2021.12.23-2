using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peter_2021._12._23_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //7. feladat: Írj programot, ami beolvassa a háromszög oldalainak hosszát,
            //és megmondja, hogy ilyen oldalakkal szerkeszthető - e háromszög!
            Console.Write("Adja meg a háromszög \"a\" számot");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Adja meg a háromszög \"b\" számot");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Adja meg a háromszög \"c\" számot");
            int c = int.Parse(Console.ReadLine());

            if (a<(b+c) && b<(a+c) && c<(b+a))
            {
                Console.WriteLine("A háromszög szerkeszthető");
            }
            else
            {
                Console.WriteLine("A háromszög nem szerkeszthető");
            }

            //8.feladat: Írj programot, mely beolvas két pozitív egész számot, és kiírja a számtani
            //és mértani közepüket!A gyökvonáshoz használd a Math.Sqrt() függvényt!
            Console.Write("Adjon meg egy egész számot: ");
            int szam1 = int.Parse(Console.ReadLine());
            
            Console.Write("Adjon meg még egy egész számot: ");
            int szam2 = int.Parse(Console.ReadLine());


            Console.WriteLine("A számok átlaga: "+(szam1+szam2)/2.0+"\nA számok mértani közepe: "+Math.Sqrt(szam1*szam2));

            //9.feladat: Írj programot, mely beolvassa a másodfokú egyenlet együtthatóit,
            //és kiírja, hogy az egyenletnek van-e megoldása!


            Console.ReadKey();
        }
    }
}
