using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI3.Heuristics.GameState
{
    public class WeightedPointsAdvantage : IGameState
    {
        public int Calculate(Board board, List<Tuple<int, int, int>> movesSequence, Player player, Player opponent) {
            int result = 0;
            Board movesBoard = new Board(board);
            foreach (Tuple<int, int, int> move in movesSequence) {
                movesBoard.SetPoint(move.Item1, move.Item2, move.Item3);
                int pointsChange = movesBoard.CalculatePointsGain(move.Item1, move.Item2);
                result += move.Item3 == player.Color ? pointsChange : -2 * pointsChange;
            }
            return player.Points + result - opponent.Points;
        }

        public override string ToString() {
            return "Ważona przewaga punktowa";
        }
    }
}
