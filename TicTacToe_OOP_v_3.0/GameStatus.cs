using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_OOP_v_3._0
{
    public class GameStatus
    {
        int[] grid;

        int playerNumber;

        public GameStatus(int[] grid, int playerNumber)
        {
            this.grid = grid;
            this.playerNumber = playerNumber;
        }

        public bool CheckWinner()
        {
            if (grid[0] == grid[1] && grid[0] == grid[2] && grid[0] == playerNumber)
            {
                return true;
            }
            else if (grid[3] == grid[4] && grid[3] == grid[5] && grid[3] == playerNumber)
            {
                return true;
            }
            else if (grid[6] == grid[7] && grid[6] == grid[8] && grid[6] == playerNumber)
            {
                return true;
            }
            else if (grid[0] == grid[3] && grid[0] == grid[6] && grid[0] == playerNumber)
            {
                return true;
            }
            else if (grid[1] == grid[4] && grid[1] == grid[7] && grid[1] == playerNumber)
            {
                return true;
            }
            else if (grid[2] == grid[5] && grid[2] == grid[8] && grid[2] == playerNumber)
            {
                return true;
            }
            else if (grid[0] == grid[4] && grid[0] == grid[8] && grid[0] == playerNumber)
            {
                return true;
            }
            else if (grid[2] == grid[4] && grid[2] == grid[6] && grid[2] == playerNumber)
            {
                return true;
            }
            else { return false; }
        }

        public bool CheckDraw()
        {
            int counter = 0;

            for (int i = 0; i < grid.Length; i++)
            {
                if (grid[i] == 0)
                {
                    counter++;
                }
            }
            if (counter == 0)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public int GetPlayerNumber()
        {
            if (CheckWinner())
            {
                return playerNumber;
            }
            else
            {
                return 0;
            }
        }
    }
}
