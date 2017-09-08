using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace FrogHopper
{
    class Program
    {
        static void Main(string[] args)
        {

            const int m = 1000000;
            Stopwatch s1 = Stopwatch.StartNew();
            for (int i = 0; i < m; i++)
            {
                FrogHops(10, 100000, 10);
            }
            s1.Stop();
            Stopwatch s2 = Stopwatch.StartNew();
            for (int i = 0; i < m; i++)
            {
                FrogHops(10, 100000, 10);
            }
            s2.Stop();
            Stopwatch s3 = Stopwatch.StartNew();
            for (int i = 0; i < m; i++)
            {
                FrogHops(10, 100000, 10);
            }
            s3.Stop();
            Console.WriteLine("{0},{1},{2}",
                s1.ElapsedMilliseconds,
                s2.ElapsedMilliseconds,
                s3.ElapsedMilliseconds);
            Console.ReadKey();





            //methodtest();
            //Console.ReadKey();
        }

        static int FrogHops(int x, int y, int d)
        {
            int i = 0;

            if (x > y)
            {
                throw new ArgumentException("X is bigger than Y");
            }

            if ((x < 1) || x > 1000000000)
            {
                throw new ArgumentException("x is not between 1 and 1.000.000.000!");
            }

            if ((y < 1) || y > 1000000000)
            {
                throw new ArgumentException("y is not between 1 and 1.000.000.000!");
            }

            if ((d < 1) || d > 1000000000)
            {
                throw new ArgumentException("d is not between 1 and 1.000.000.000!");
            }

            while (x < y)
            {
                x += d;
                i++;
            }


            return i;
        }

        static void methodtest()
        {
            Random rand = new Random();

            Console.Write("How many loops? ");
            int loop = Int32.Parse(Console.ReadLine());

            Console.Write("X min? ");
            int xmin = Int32.Parse(Console.ReadLine());

            Console.Write("X max? ");
            int xmax = Int32.Parse(Console.ReadLine());

            Console.Write("Y min? ");
            int ymin = Int32.Parse(Console.ReadLine());

            Console.Write("Y max? ");
            int ymax = Int32.Parse(Console.ReadLine());

            Console.Write("D min? ");
            int dmin = Int32.Parse(Console.ReadLine());

            Console.Write("D max? ");
            int dmax = Int32.Parse(Console.ReadLine());

            for (int i = 0; i <= loop; i++)
            {

                try
                {
                    int x = rand.Next(xmin, xmax);
                    int y = rand.Next(ymin, ymax);
                    int d = rand.Next(dmin, dmax);
                    Console.Write("\nCount:" + i + " --- X = " + x + " Y = " + y + " D = " + d + ": ");
                    FrogHops(x, y, d);



                }
                catch (Exception E)
                {

                    Console.Write("Fail - ");
                    Console.Write(E.Message);
                }
            }

            Console.WriteLine("TESTED {0} times with: X = {1} - {2}, Y = {3} - {4}, D = {5} - {6}", loop, xmin, xmax, ymin, ymax, dmin, dmax);









        }
    }
}
