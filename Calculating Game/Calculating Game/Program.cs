using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculating_Game
{
    class Program
    {
        static void Main()
        {
            int Input = 0;

            Console.WriteLine("Choose discipline: \n 1. Addition \n 2. Subtraction \n 3. Multiply \n 4. Divide \n 5. Exit \n Choose: ");
            Input = Convert.ToInt32(Console.ReadLine());
            switch (Input)
            {
                case 1:
                    {
                        Add(RandomNumbers());
                        break;
                    }
                case 2:
                    {
                        break;
                    }
                case 3:
                    {
                        break;
                    }
                case 4:
                    {
                        break;
                    }
                case 5:
                    {
                        break;
                    }
                    
            }
        }
        static int Add(int[,] NumbersArray)
        {
            foreach (var item in NumbersArray)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadKey();
            return 1;
            
        }
        //static int Subtract()
        //{

        //}
        //static int Multiply()
        //{

        //}
        //static int Divide()
        //{

        //}
        static int[,] RandomNumbers()
        {
            int input = 0;
            Random random = new Random();
            int LevelMin = 0;
            int LevelMax = 0;

            int[,] NumbersArray = new int[10, 2];
            Console.WriteLine("Choose difficulty: \n 1. Level 1 \n 2. Level 2 \n 3. Level 3 \n 4. Level 4 \n : ");
            input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    {
                        LevelMin = 1;
                        LevelMax = 10;
                        break;
                    }
                case 2:
                    {
                        LevelMin = 1;
                        LevelMax = 100;
                        break;
                    }
                case 3:
                    {
                        LevelMin = 1;
                        LevelMax = 1000;
                        break;
                    }
                case 4:
                    {
                        LevelMin = 1;
                        LevelMax = 10000;
                        break;
                    }
            }
            for (int i = 0; i <= 9; i++)
            {
                for (int x = 0; x < 2; x++)
                {
                    NumbersArray[i,x] = random.Next(LevelMin, LevelMax);
                }
            }
            return NumbersArray;
        }
        static int CalcCreater(int[,] NumbersArray)
        {
            int points = 0;

            return points;
        }
    }
}
