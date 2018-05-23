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
        int currentPlayerIndex;
        Color[] colors = new Color[] { Color.Green, Color.Red };

        public BoardForm(int size, List<Player> players) {
            InitializeComponent();
            this.players = players;
            CreateBoard(size);
            SetLabelsValues();
            currentPlayerIndex = 0;
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
                    field.MouseDown += HandleFieldClick;
                    boardPanel.Controls.Add(field);
                    field.Location = new Point(i * fieldSize + i, j * fieldSize + j); 
                }
            }
        }

        void SetLabelsValues() {
            if (players[0].GetType() == typeof(AIPlayer)) {
                player1AlgorithmNameLabel.Text = ((AIPlayer)players[0]).Algorithm.ToString();
                player1GameStateHeuristicNameLabel.Text = ((AIPlayer)players[0]).GameStateCalculator.ToString();
                if (((AIPlayer)players[0]).NodeSelector != null) {
                    player1NodeChoiceHeuristicNameLabel.Text = ((AIPlayer)players[0]).NodeSelector.ToString();
                } else {
                    player1NodeChoiceHeuristicLabel.Visible = false;
                    player1NodeChoiceHeuristicNameLabel.Visible = false;
                }
            } else {
                player1AlgorithmLabel.Visible = false;
                player1AlgorithmNameLabel.Visible = false;
                player1GameStateHeuristicLabel.Visible = false;
                player1GameStateHeuristicNameLabel.Visible = false;
                player1NodeChoiceHeuristicLabel.Visible = false;
                player1NodeChoiceHeuristicNameLabel.Visible = false;
            }

            if (players[1].GetType() == typeof(AIPlayer)) {
                player2AlgorithmNameLabel.Text = ((AIPlayer)players[1]).Algorithm.ToString();
                player2GameStateHeuristicNameLabel.Text = ((AIPlayer)players[1]).GameStateCalculator.ToString();
                if (((AIPlayer)players[1]).NodeSelector != null) {
                    player2NodeChoiceHeuristicNameLabel.Text = ((AIPlayer)players[1]).NodeSelector.ToString();
                } else {
                    player2NodeChoiceHeuristicLabel.Visible = false;
                    player2NodeChoiceHeuristicNameLabel.Visible = false;
                }
            } else {
                player2AlgorithmLabel.Visible = false;
                player2AlgorithmNameLabel.Visible = false;
                player2GameStateHeuristicLabel.Visible = false;
                player2GameStateHeuristicNameLabel.Visible = false;
                player2NodeChoiceHeuristicLabel.Visible = false;
                player2NodeChoiceHeuristicNameLabel.Visible = false;
            }
        }

        public void HandleNextMove() {
            Refresh();
            if (board.GetAvailableMoves().Any()) {
                if (players[currentPlayerIndex].GetType() == typeof(AIPlayer)) {
                    Tuple<int, int> move = players[currentPlayerIndex].ChooseMove(board);
                    UpdateBoard(move);                  
                }
            }
        }

        void UpdateBoard(Tuple<int, int> move) {
            board.SetPoint(move.Item1, move.Item2, players[currentPlayerIndex].Color);
            players[currentPlayerIndex].AddPoints(board.CalculatePointsGain(move.Item1, move.Item2));

            player1PointsValueLabel.Text = players[0].Points.ToString();
            player2PointsValueLabel.Text = players[1].Points.ToString();

            boardPanel
                .Controls
                .Find(move.Item1 + " " + move.Item2, true)
                .FirstOrDefault()
                .BackColor = colors[players[currentPlayerIndex].Color - 1];

            currentPlayerIndex = currentPlayerIndex + 1 >= players.Count ? 0 : currentPlayerIndex + 1;
            HandleNextMove();
        }

        public void HandleFieldClick(object sender, EventArgs e) {
            try {
                string[] coords = ((PictureBox)sender).Name.Split(' ');
                int row = Int32.Parse(coords[0]);
                int column = Int32.Parse(coords[1]);

                if (board.IsFieldEmpty(row, column)) {
                    UpdateBoard(new Tuple<int, int>(row, column));
                } else {
                    MessageBox.Show("Wybrane pole jest zajęte!");
                }
            } catch(Exception) {
                MessageBox.Show("Wystąpił problem z rozpoznaniem ruchu!");
            }
        }
    }
}
