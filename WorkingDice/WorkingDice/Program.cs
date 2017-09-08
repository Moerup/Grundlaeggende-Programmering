using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceThrow2
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            //Random værdi med navn random
            int NumbOfDices = 0;
            Console.WriteLine("Choose number of dices:");
            NumbOfDices = Convert.ToInt16(Console.ReadLine());
            int[] throws = new int[NumbOfDices];
            //Laver Array med antal pladser opgivet i NumbOfDices
            int i = 1;
            do
            {
                Console.WriteLine("Throws: {0:D}", i);
                for (int x = 0; x < NumbOfDices; x++)
                //looper indtil x er større end NumbOfDices. Kaster med alle terninger, afhænger af hvor mange du har opgivet.

                {
                    throws[x] = random.Next(1, 7);
                    //Laver en random værdi imellem 1 og 7 (7 tages ikke med) og putter den i arrayed throws
                }
                i++;
            } while (!Array.TrueForAll(throws, item => item == 6));
            //Bliver ved indtil at hele arrayed indeholder rene 6´ere
            Console.WriteLine("It took {0:D} throws to get {1:D} sixes", i, NumbOfDices);
            Console.ReadKey();
            {

            }
        }
    }
}