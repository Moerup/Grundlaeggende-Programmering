using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITD.GrundlægProgram
{
    class Program
    {
        static void Main(string[] args)
         
        {
            string FuldtKøn = "";
            int Årstal = DateTime.Now.Year;
            int Alder;
            Console.WriteLine("Indtast Fornavn:");
            string Fornavn = Console.ReadLine();
            Console.WriteLine("Indtast Efternavn:");
            string Efternavn = Console.ReadLine();
            
            bool correct;
            correct = false;
            do
            {
                Console.WriteLine("Indtast Alder:");
                string input = Console.ReadLine();
                correct = int.TryParse(input, out Alder);
            }
            while (!correct);
            Console.Write("Indtast køn - M = Mand | K = Kvinde:");
            char Køn = Convert.ToChar(Console.ReadLine());
            correct = false;
            
            while (correct == false)
            { 
            
            if (Køn == 'M')
            {
                FuldtKøn = "mand";
                correct = true;
            }
            else if(Køn == 'K')
            {
                FuldtKøn = "kvinde";
                correct = true;
            }
            else
            {
                Console.WriteLine("Godtager kun M og K");
            }

            }
            Console.WriteLine("Hvor gammel skal man være for at være gammel?");
            int Gammel = Convert.ToInt32(Console.ReadLine());
            int GamÅrstal = Årstal + (Gammel-Alder);
            if (Alder < Gammel)
            {
                Console.WriteLine("Der er " + (Gammel - Alder) + " år til du bliver gammel");

                Console.WriteLine("Du bliver gammel i årstallet " + GamÅrstal);
            }
            else
            {

                Console.WriteLine("Du er en gammel " + FuldtKøn);
            }
            Console.Read();

        }
    }
}
