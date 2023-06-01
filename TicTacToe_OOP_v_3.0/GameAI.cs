using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_OOP_v_3._0
{
    public class GameAI
    {

        public Board board;

        public List<ButtonCustomize> buttons = new List<ButtonCustomize>();

        public List<Control> controls = new List<Control>();

        public GameWithUser GameWithUser;

        public GameWithAI GameWithAI;

        Label label, label_player = new Label();

        public GameAI()
        {

            buttons = new List<ButtonCustomize>();

            board = new Board();

            label = new Label();

            label.Text = "";
            label.Location = new Point(761, 42);
            label.Font = new Font("Algerian", 14);

            for (int i = 0; i < board.grid.Length / 3; i++)
            {
                for (int j = 0; j < board.grid.Length / 3; j++)
                {
                    ButtonCustomize buttonCustomize = new ButtonCustomize(i, j);
                    buttons.Add(buttonCustomize);
                    controls.Add(buttonCustomize.Button);
                }
            }

            controls.Add(label);

            GameWithAI = new GameWithAI(buttons, board, label);

            for (int i = 0; i < buttons.Count; i++)
            {
                buttons[i].Button.Click += new EventHandler(GameWithAI.StartGameWithAI);
            }

        }

    }
}
