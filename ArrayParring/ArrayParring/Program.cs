using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchArr
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = {1,1,2,2,7};
            //Deklarer et array med nogle værdier
            try
            {
                MatchArr(A);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }

        static int MatchArr(int[] A)
        {
            int leftOver = 0;

            if (IsEven(A.Length))
                throw new ArgumentException("Array is not uneven");

            if (A.Length < 1 || A.Length >= 1000000)
                throw new ArgumentException("Array length is out of scope");

            foreach (int item in A)
            {
                if (item < 1 || item > 1000000000)
                    throw new ArgumentException("Element is out of scope!");
            }

            int hits = 0;
            int value = 0;
            bool checkformore = false;

            foreach (int item in A)
                //for hvert element (item) i arrayed A
            {
                hits = 0;
                for (int i = 0; i < A.Length; i++)
                {
                    if (item == A[i])
                    {
                        hits++;
                    }
                    //Starter på en værdi fx 0 og kører hele arrayed igennem for at checke om den eksisterer flere gange
                }

                if (!IsEven(hits) && checkformore == false)
                    //Hvis metoden IsEven og checkformore returnere false kør koden
                {
                    value = item;
                    checkformore = true;
                }
                else if (checkformore == true)
                {
                    throw new ArgumentException("Multiple single numbers");
                }
            }

            Console.WriteLine(value + " is missing a partner!");
            return leftOver;
        }

        public static bool IsEven(int value)
        {
            return value % 2 == 0;
        }
        //Checker om arrayed er et ulige antal 
    }
}

