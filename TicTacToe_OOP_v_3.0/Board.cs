using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_OOP_v_3._0
{
    public class Board
    {
        private const int boardSize = 9;

        public int[] grid;

        public Board()
        {
            grid = new int[boardSize];
            foreach(int i in grid) grid[i] = 0;
        }
    }
}
