using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_OOP_v_3._0
{
    public class GameWithUser
    {

        public List<ButtonCustomize> buttonCustomizes;

        public Board board;

        public int k = 0;

        Label label, label_player;

        public GameWithUser(Board board, List<ButtonCustomize> buttonCustomizes, Label label, Label label_player) 
        {
            this.board = board;
            this.buttonCustomizes = buttonCustomizes;
            this.label = label;
            this.label_player = label_player;
        }

        int currentPlayer = 1;

        int[] checkBoard;

        public void StartGameWithUser(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            int[] grid = board.grid;

            int position = 0;

            GameStatus status = new GameStatus(grid, currentPlayer);
            

            for (int i = 0; i < buttonCustomizes.Count; i++)
            {
                if (buttonCustomizes[i].Button == button)
                {
                    position = i;
                }
            }

            if (grid[position] == 0)
            {
                grid[position] = currentPlayer;
                button.Text = currentPlayer == 1 ? "X" : "0";
                currentPlayer = currentPlayer == 1 ? 2 : 1;
                label_player.Text = currentPlayer == 1 ? "X" : "0";
                k++;
                label.Text = k.ToString();
                checkBoard = grid;
                if (status.CheckWinner())
                {
                    MessageBox.Show("Виграл игрок" + grid[position].ToString());
                    NewGame();
                } 
            }

            if (status.CheckDraw())
            {
                MessageBox.Show("Ничья");
                NewGame();
            }

            void NewGame()
            {
                for (int i = 0; i < checkBoard.Length; i++)
                {
                    checkBoard[i] = 0;
                    buttonCustomizes[i].Button.Text = "";
                }
                currentPlayer = 1;
                k = 0;
                label.Text = "";
                label_player.Text = "Х";
            }

        }
        
    }
}
