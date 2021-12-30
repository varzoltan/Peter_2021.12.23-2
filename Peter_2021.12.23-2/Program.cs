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
            int d = int.Parse(Console.ReadLine());

            Console.Write("Adja meg a háromszög \"b\" számot");
            int e = int.Parse(Console.ReadLine());

            Console.Write("Adja meg a háromszög \"c\" számot");
            int f = int.Parse(Console.ReadLine());

            if (d<(e+f) && e<(d+f) && f<(e+d))
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
            /*Console.Write("Adja meg a háromszög \"a\" számot: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Adja meg a háromszög \"b\" számot: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Adja meg a háromszög \"c\" számot: ");
            int c = int.Parse(Console.ReadLine());

            if((b*b)-4*a*c >= 0)
            {
                Console.WriteLine("A másodfokú egyenletnek VAN megoldása!");
            }
            else
            {
                Console.WriteLine("A másodfokú egyenletnek NINCS megoldása!");
            }*/

            //10. feladat: Írj programot, ami beolvassa a másodfokú egyenlet együtthatóit,
            //és kiírja az egyenlet megoldásait, ha vannak!
            Console.Write("Adja meg a háromszög \"a\" számot: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Adja meg a háromszög \"b\" számot: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Adja meg a háromszög \"c\" számot: ");
            int c = int.Parse(Console.ReadLine());
            int negyzetgyok = b * b - 4 * a * c;
            double X1X2 = 0;
            double X1 = 0;
            double X2 = 0;

            if(negyzetgyok == 0)
            {
                X1X2 = -b / (double)(2 * a);
                Console.WriteLine($"Az eredmény: {X1X2}");
            }
            else if (negyzetgyok > 0)
            {
                X1 = -b + Math.Sqrt(negyzetgyok) / 2 * a;
                X2 = -b - Math.Sqrt(negyzetgyok) / 2 * a;
                Console.WriteLine($"X1 = {X1.ToString("0.000")} \nX2 = {X2.ToString("0.00")}");
            }
            else
            {
                Console.WriteLine("A másodfokú egyenletnek nincs megoldása!");
            }

            //11.felafódat: Írj programot, mely beolvassa egy derékszögű háromszög
            //két befogóját, és megadja az átfogójának a hosszát!
            //Az átfogót 2 tizedesjeggyel add meg.
            Console.Write("Adja meg a háromszög egyik befogóját: ");
            int a_befogo = int.Parse(Console.ReadLine());

            Console.Write("Adja meg a háromszög másik befogóját: ");
            int b_befogo = int.Parse(Console.ReadLine());

            //double c_befogo

            

            Console.ReadKey();
        }
    }
}
