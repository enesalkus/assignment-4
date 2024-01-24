using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tic_tac_toe_game
{
    public class Functions
    {
        public void drawTable(char[] list)
        {
            int tempStep = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 1; j <= 11; j++)
                {
                    if (j % 4 == 0)
                    {
                        Console.Write("|");
                    }
                    else if (j % 2 == 0)
                    {
                        Console.Write((list[tempStep] == 'X' || list[tempStep] == 'O') ? list[tempStep] : ' ');
                        tempStep++;
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                if (i < 2) Console.WriteLine("\n---+---+---");
            }
            Console.WriteLine("\n");
        }
        public bool checkWinner(char[] list, char player)
        {
            for (int i = 0; i < 3; i++)
            {
                if (list[i * 3] == player && list[i * 3 + 1] == player && list[i * 3 + 2] == player
                    || list[i] == player && list[i + 3] == player && list[i + 6] == player)
                    return true;
            }
            if (list[0] == player && list[4] == player && list[8] == player || list[2] == player && list[4] == player && list[6] == player)
                return true;
            return false;
        }
    }
}
