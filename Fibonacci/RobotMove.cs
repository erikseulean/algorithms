using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    public class RobotMove
    {
        private int count;
        private int size;

        private int[,] matrix = new int[,]
        {
            {0, 0, 1, 0,0},
            {0, 0, 0, 0,0},
            {0, 1, 0, 0,0},
            {0, 1, 0, 0,0},
            {0, 1, 0, 0,0},
        };
        public RobotMove(int n)
        {
            size = n;
        }

        public void RobotStep(int i, int j)
        {
            if (i == size-1 && j == size-1)
                count++;
            else
            {
                if(i  < size && matrix[i+1,j] == 0) RobotStep(i+1,j);
                if(j  < size && matrix[i,j+1] == 0) RobotStep(i,j+1);
            }
        }

        public void Robot()
        {
            RobotStep(0,0);
            Console.WriteLine(count);
        }
    }
}
