using SI3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class BoardForm : Form
    {
        Board board;
        List<Player> players;

        public BoardForm(int size, List<Player> players) {
            InitializeComponent();
            CreateBoard(size);
            this.players = players;
        }

        void CreateBoard(int size) {
            board = new Board(size);
            int fieldSize = (boardPanel.Size.Width - (size - 1)) / size;
            for (int i = 0; i < size; i++) {
                for (int j = 0; j < size; j++) {
                    PictureBox field = new PictureBox {
                        BackColor = Color.White,
                        Size = new Size(fieldSize, fieldSize),
                        Name = i + " " + j
                    };
                    boardPanel.Controls.Add(field);
                    field.Location = new Point(i * fieldSize + i, j * fieldSize + j); 
                }
            }
        }
    }
}
