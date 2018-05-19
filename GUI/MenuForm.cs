using SI3;
using SI3.Algorithms;
using SI3.Heuristics.GameState;
using SI3.Heuristics.NodeChoice;
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
    public partial class MenuForm : Form
    {
        public MenuForm() {
            InitializeComponent();
            FillAlgorithmComboBoxes();
            FillGameStateHeuristicComboBoxes();
        }

        void FillAlgorithmComboBoxes() {
            IAlgorithm minMax = new MinMax();
            player1AlgorithmChoice.Items.Add(minMax);
            player2AlgorithmChoice.Items.Add(minMax);
        }

        void FillGameStateHeuristicComboBoxes() {
            IGameState pointsGain = new PointsGain();
            player1GameStateHeuristicChoice.Items.Add(pointsGain);
            player2GameStateHeuristicChoice.Items.Add(pointsGain);
        }

        private void Player1AICheckboxCheckedChanged(object sender, EventArgs e) {
            bool checkboxChecked = ((CheckBox)sender).Checked;
            player1TreeDepthChoice.Enabled = checkboxChecked;
            player1AlgorithmChoice.Enabled = checkboxChecked;
            player1GameStateHeuristicChoice.Enabled = checkboxChecked;
            player1NodeChoiceHeuristicChoice.Enabled = checkboxChecked;          
        }

        private void Player2AICheckboxCheckedChanged(object sender, EventArgs e) {
            bool checkboxChecked = ((CheckBox)sender).Checked;
            player2TreeDepthChoice.Enabled = checkboxChecked;
            player2AlgorithmChoice.Enabled = checkboxChecked;
            player2GameStateHeuristicChoice.Enabled = checkboxChecked;
            player2NodeChoiceHeuristicChoice.Enabled = checkboxChecked;
        }

        bool IsSettingsStateValid() {
            if(player1AICheckbox.Checked) {
                if(player1GameStateHeuristicChoice.SelectedItem == null) {
                    return false;
                } else if(player1AlgorithmChoice == null) {
                    return false;
                }
            }
            if(player2AICheckbox.Checked) {
                if (player2GameStateHeuristicChoice.SelectedItem == null) {
                    return false;
                }
                else if (player2AlgorithmChoice == null) {
                    return false;
                }
            }
            return true;
        }

        private void StartGameButtonClick(object sender, EventArgs e) {
            if (IsSettingsStateValid()) {
                Player player1;
                if (player1AICheckbox.Checked) {
                    player1 = new AIPlayer(1,
                        (int)player1TreeDepthChoice.Value,
                        (IGameState)player1GameStateHeuristicChoice.SelectedItem,
                        (INodeChoice)player1NodeChoiceHeuristicChoice.SelectedItem,
                        (IAlgorithm)player1AlgorithmChoice.SelectedItem
                    );
                }
                else {
                    player1 = new HumanPlayer(1);
                }

                Player player2;
                if (player2AICheckbox.Checked) {
                    player2 = new AIPlayer(2,
                        (int)player2TreeDepthChoice.Value,
                        (IGameState)player2GameStateHeuristicChoice.SelectedItem,
                        (INodeChoice)player2NodeChoiceHeuristicChoice.SelectedItem,
                        (IAlgorithm)player2AlgorithmChoice.SelectedItem
                    );
                }
                else {
                    player2 = new HumanPlayer(2);
                }

                List<Player> players = new List<Player> { player1, player2 };
                int boardSize = (int)boardSizeChoice.Value;

                BoardForm boardForm = new BoardForm(boardSize, players);
                boardForm.Show();
            } else {
                MessageBox.Show("Niedozwolona kombinacja ustawień!");
            }
        }
    }
}
