using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI3.Heuristics.GameState
{
    public class PointsAdvantage : IGameState
    {
        public int Calculate(Board board, Tuple<int, int> move, Player player, Player opponent) {
            Console.WriteLine(player.Points + board.CalculatePointsGain(move.Item1, move.Item2) - opponent.Points);
            return player.Points + board.CalculatePointsGain(move.Item1, move.Item2) - opponent.Points;          
        }

        public override string ToString() {
            return "Przewaga punktowa";
        }
    }
}
