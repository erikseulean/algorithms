using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ModerateProblems
{
    public class TicTacToe
    {
        public static bool IsWinner(int[,] matrix)
        {
            if ((matrix[0, 0] == matrix[1, 1] && matrix[1, 1] == matrix[2, 2])||
                (matrix[2,0] == matrix[1,1] && matrix[1,1] == matrix[0,2]))
                    return true;
            for (int i = 0; i < 3; i++)
                if ((matrix[0, i] == matrix[1, i] && matrix[1, i] == matrix[2, i]) ||
                    (matrix[i, 0] == matrix[i, 1] && matrix[i, 1] == matrix[i, 2]))
                    return true;
            return false;
        }
    }
}
