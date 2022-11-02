using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanke_And_Ladder_Problem
{
    internal class Snake
    {
        public const int Ahead_Move = 1;
        public const int Behind_Move = 2;
        public const int No_Move = 3;
        public void player()
        {
            int position1 = 0;

            Random random = new Random();
            while (position1 != 100)
            {
                int MovingCheck = random.Next(1, 6);
                int StepCheck = random.Next(1, 3);
                Console.WriteLine($"Roll Die is : {MovingCheck}");
                Console.WriteLine($"Moving Check is : {StepCheck}");

                switch (StepCheck)
                {
                    case Ahead_Move:
 
                            position1 = position1 + MovingCheck;
                            Console.WriteLine("Ahead Move");
                        
                        break;
                    case Behind_Move:

                            position1 = position1 - MovingCheck;
                            Console.WriteLine("Behind Move");

                        break;
                    case No_Move:

                        position1 = position1 + MovingCheck;
                        Console.WriteLine("No Move");

                        break;
                }
                Console.WriteLine("Step Count is :" + position1);
            }
        }
    }
}
