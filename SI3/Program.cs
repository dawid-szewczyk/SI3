using SI3.Algorithms;
using SI3.Heuristics.GameState;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI3
{
    class Program
    {
        static void Main(string[] args) {
            Board board = new Board(4);
            List<Player> players = new List<Player> {
                new AIPlayer(1, 3, new PointsAdvantage(), null, new AlphaBeta(), board),
                new AIPlayer(2, 3, new PointsGain(), null, new MinMax(), board)
            };

            if(players[0].GetType() == typeof(AIPlayer)) {
                ((AIPlayer)players[0]).Opponent = players[1];
            }

            if (players[1].GetType() == typeof(AIPlayer)) {
                ((AIPlayer)players[1]).Opponent = players[0];
            }

            while (board.GetAvailableMoves().Any()) {          
                foreach(Player player in players) {
                    if (board.GetAvailableMoves().Any()) {
                        Console.Write("Stan gry -");
                        players.ForEach(p => Console.Write($" gracz{p.Color}: {p.Points}"));
                        Console.Write("\n");
                        board.Print();

                        Tuple<int, int> move = player.ChooseMove();
                        board.SetPoint(move.Item1, move.Item2, player.Color);
                        player.AddPoints(board.CalculatePointsGain(move.Item1, move.Item2));
                    }
                }
            }
            List<Player> winners = players.Where(p => p.Points == players.Max(p2 => p2.Points)).ToList();

            if(winners.Count > 1) {
                Console.WriteLine("Remis!");
                winners.ForEach(w => Console.WriteLine($"Gracz{w.Color} z liczbą punktów równą {w.Points}"));
            } else if (winners.Count == 1) {
                Console.WriteLine($"Wygrał gracz{winners[0].Color} z liczbą punktów równą {winners[0].Points}");
            } else {
                Console.WriteLine("Nie ma graczy - nie ma gry.");
            }
        }
    }
}
