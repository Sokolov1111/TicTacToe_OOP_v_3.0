using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_OOP_v_3._0
{
    public class GameWithAI
    {
        public List<ButtonCustomize> buttonCustomizes;

        public Board board;

        public int k = 0;

        Label label;

        public GameWithAI(List<ButtonCustomize> buttonCustomizes, Board board, Label label)
        {
            this.buttonCustomizes = buttonCustomizes;
            this.board = board;
            this.label = label;
        }

        public void StartGameWithAI(object sender, EventArgs e)
        {
            Button button = (Button) sender;


            int[] grid = board.grid;

            MiniMax miniMax = new MiniMax(grid);

            int position = 0;
         
            for (int i = 0; i < buttonCustomizes.Count; i++)
            {
                if (buttonCustomizes[i].Button == button)
                {
                    position = i;
                }
            }

            GameStatus status1 = new GameStatus(grid, 1);
            GameStatus status2 = new GameStatus(grid, 2);

            if (grid[position] == 0)
            {
                grid[position] = 1;
                button.Text = "X";
                int bestMove = miniMax.findBestMove();
                grid[bestMove] = 2;
                buttonCustomizes[bestMove].Button.Text = "0";
                k += 2;
                if (k == 10)
                {
                    k = 9;
                }

                label.Text = k.ToString();
                if (status1.CheckWinner())
                {
                    MessageBox.Show("Выиграл игрок 1 ");
                    NewGame();
                }
                else if (status2.CheckWinner())
                {
                    MessageBox.Show("Выиграл игрок 2 ");
                    NewGame();
                }
            }

            if (status1.CheckDraw() || status2.CheckDraw())
            {
                MessageBox.Show("Ничья");
                NewGame();
            }

            void NewGame()
            {
                for (int i = 0; i < grid.Length; i++)
                {
                    grid[i] = 0;
                    buttonCustomizes[i].Button.Text = "";
                    k = 0;
                    label.Text = "";
                }

            }

        }

    }
}
