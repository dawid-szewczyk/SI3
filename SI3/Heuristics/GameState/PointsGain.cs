using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI3.Heuristics.GameState
{
    public class PointsGain : IGameState
    {
        public int Calculate(Board board, List<Tuple<int, int, int>> movesSequence, Player player, Player opponent) {
            //return board.CalculatePointsGain(move.Item1, move.Item2);
            int result = 0;
            Board movesBoard = new Board(board);
            foreach (Tuple<int, int, int> move in movesSequence) {
                movesBoard.SetPoint(move.Item1, move.Item2, move.Item3);
                if(move.Item3 == player.Color) {
                    result += movesBoard.CalculatePointsGain(move.Item1, move.Item2);
                }
            }
            return result;
        }

        public override string ToString() {
            return "Zysk punktowy";
        }
    }
}
