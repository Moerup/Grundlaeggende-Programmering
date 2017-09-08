using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10x10_tabel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            for(int i = 1; i <= 10; i++)
            {
                string y = "";
                for(int x = i; x <=i*10;x+=i)
                {
                    y = y + x.ToString().PadLeft(4);
                }
                Console.WriteLine(y);
            }
            Console.ReadKey();
        }
    }
}
