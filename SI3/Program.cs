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
            Board board = new Board(6);
            List<Player> players = new List<Player> {
                new AIPlayer(1, 4, new PointsGain(), null, new MinMax()),
                new AIPlayer(2, 4, new PointsGain(), null, new AlphaBeta())
            };

            while(board.GetAvailableMoves().Any()) {          
                foreach(Player player in players) {
                    if (board.GetAvailableMoves().Any()) {
                        Console.Write("Stan gry -");
                        players.ForEach(p => Console.Write($" gracz{p.Color}: {p.Points}"));
                        Console.Write("\n");

                        board.Print();
                        Stopwatch stopwatch = new Stopwatch();
                        stopwatch.Start();
                        Tuple<int, int> move = player.ChooseMove(board);
                        stopwatch.Stop();
                        Console.Write("czas decyzji: " + stopwatch.Elapsed);
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
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
