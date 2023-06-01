using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_OOP_v_3._0
{
    public class ButtonCustomize
    {
        private Button button;

        private const int button_size = 90;
        private const int button_padding = 10;

        public ButtonCustomize(int x, int y)
        {
            button = new Button();
            button.Text = "";
            button.Location = new Point(y * (button_size + button_padding), x * (button_size + button_padding));
            button.Size = new Size(button_size, button_size);
            button.Font = new Font("Arial", 24);
            button.BackColor = Color.White;
        }

        public Button Button
        {
            get { return button; }
        }

        public Point Location
        {
            get { return button.Location; }
            set { button.Location = value; }
        }

        public Size Size
        {
            get { return button.Size; }
            set { button.Size = value; }
        }

        public Font Font
        {
            get { return button.Font; }
            set { button.Font = value; }
        }

        public Color BackColor
        {
            get { return button.BackColor; }
            set { button.BackColor = value; }
        }
    }
}
