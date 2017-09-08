using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace FrogJumping
{
    class Program
    {
        static void Main(string[] args)
        {


            const int m = 1000000;
            Stopwatch s1 = Stopwatch.StartNew();
            for (int i = 0; i < m; i++)
            {
                FrogJumps(10, 10, 100000);
            }
            s1.Stop();
            Stopwatch s2 = Stopwatch.StartNew();
            for (int i = 0; i < m; i++)
            {
                FrogJumps(10, 10, 100000);
            }
            s2.Stop();
            Stopwatch s3 = Stopwatch.StartNew();
            for (int i = 0; i < m; i++)
            {
                FrogJumps(10, 10, 100000);
            }
            s3.Stop();
            Console.WriteLine("{0},{1},{2}",
                s1.ElapsedMilliseconds,
                s2.ElapsedMilliseconds,
                s3.ElapsedMilliseconds);
            Console.ReadKey();




            /* Console.Write("JumpDistance: ");
            int JumpDistance = Convert.ToInt32(Console.ReadLine());
            Console.Write("StartPosition: ");
            int StartPosition = Convert.ToInt32(Console.ReadLine());
            Console.Write("EndPosition: ");
            int EndPosition = Convert.ToInt32(Console.ReadLine());
            int HopCount = 0;
            try
            {
                HopCount = FrogJumps(JumpDistance, StartPosition, EndPosition);
                Console.WriteLine("It took {0:D} jumps for the frog to cross the road!", HopCount);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
            */
        }
        static int FrogJumps(int JumpDistance, int StartPosition, int EndPosition)
        {
            int Jumps = 0;
            int CurrentPosition = StartPosition;
            if (JumpDistance < 1 || JumpDistance > 1000000000)
            {
                throw new ArgumentException("Error - Jumpdistance should be between 1 - 1.000.000.000");
            }
            if (StartPosition < 1 || StartPosition > 1000000000)
            {
                throw new ArgumentException("Error - StartPosition should be between 1 - 1.000.000.000");
            }
            if (EndPosition < 1 || EndPosition > 1000000000)
            {
                throw new ArgumentException("Error - EndPosition should be between 1 - 1.000.000.000");
            }
            if (StartPosition > EndPosition)
            {
                throw new ArgumentException("Error - StartPosition can't be bigger than Endposition");
            }
            while (CurrentPosition < EndPosition)
            {
                CurrentPosition += JumpDistance;
                Jumps++;
            }
            return Jumps;
        }
    }
}