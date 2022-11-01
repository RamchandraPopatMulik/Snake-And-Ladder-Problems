using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanke_And_Ladder_Problem
{
    internal class Snake
    {
        public void player()
        { 
           Random random = new Random();
           int Die = random.Next(1,6);
           Console.WriteLine($"Roll Die is : {Die}");
        }
    }
}
