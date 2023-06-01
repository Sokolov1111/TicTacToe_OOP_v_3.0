using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe_OOP_v_3._0;

namespace TicTacToe_OOP_v_3._0
{
    public partial class Form3 : Form
    {
        GameAI gameWithAI = new GameAI();

        public Form3()
        {
            InitializeComponent();
            Controls.AddRange(gameWithAI.controls.ToArray());
        }

    }
}
