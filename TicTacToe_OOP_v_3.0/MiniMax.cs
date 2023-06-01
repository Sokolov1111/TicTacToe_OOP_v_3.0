using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_OOP_v_3._0
{
    public class MiniMax
    {
        
        int[] board;

        public MiniMax(int[] board)
        {
            this.board = board;
        }

        int human = 1;
        int AI = 2;

        public int findBestMove()
        {
            int bestScore = -1000;
            int bestMove = 0;

            for (int i = 0; i < board.Length; i++)
            {
                if (board[i] == 0)
                {
                    board[i] = 2;
                    int score = minimax(board, 0, false);
                    board[i] = 0;
                    if (score > bestScore)
                    {
                        bestScore = score;
                        bestMove = i;
                    }
                }
            }
            return bestMove;
        }

        public int minimax(int[] board, int depth, bool isMaximizing)
        {
            GameStatus status1 = new GameStatus(board, human);
            GameStatus status2 = new GameStatus(board, AI);

            if (status2.CheckWinner())
            {
                return 100;
            }
            else if (status1.CheckWinner())
            {
                return -100;
            }
            else if (status1.CheckDraw() || status2.CheckDraw())
            {
                return -1;
            }
            if (isMaximizing)
            {
                int bestScore = -1000;

                for (int i = 0; i < board.Length; i++)
                {
                    if (board[i] == 0)
                    {
                        board[i] = 2;
                        int score = minimax(board, 0, false);
                        board[i] = 0;
                        if (score > bestScore)
                        {
                            bestScore = score;
                        }
                    }
                }
                return bestScore;
            }
            else
            {
                int bestScore = 800;

                for (int i = 0; i < board.Length; i++)
                {
                    if (board[i] == 0)
                    {
                        board[i] = 1;

                        int score = minimax(board, 0, true);
                        board[i] = 0;
                        if (score < bestScore)
                        {
                            bestScore = score;
                        }
                    }
                }
                return bestScore;
            }

        }
    }
}
