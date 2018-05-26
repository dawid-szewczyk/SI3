using SI3.Algorithms;
using SI3.Heuristics.GameState;
using SI3.Heuristics.NodeChoice;
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
            Board board = new Board(7);
            List<Player> players = new List<Player> {
                new AIPlayer(1, 4, new PointsAdvantage(), new MinFirstSelector(), new AlphaBeta(), board),
                new AIPlayer(2, 4, new PointsAdvantage(), new MaxFirstSelector(), new AlphaBeta(), board)
            };

            if(players[0].GetType() == typeof(AIPlayer)) {
                ((AIPlayer)players[0]).Opponent = players[1];
            }

            if (players[1].GetType() == typeof(AIPlayer)) {
                ((AIPlayer)players[1]).Opponent = players[0];
            }

            //Stopwatch sw = Stopwatch.StartNew();
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
            //sw.Stop();
            //Console.WriteLine("Czas całej gry: " + sw.ElapsedMilliseconds + "ms");
            foreach(AIPlayer player in players.OfType<AIPlayer>()) {
                Console.WriteLine("Statystyki gracza " + player.Color);
                Console.WriteLine($"Najdłuższy czas ruchu: {player.Times.Max()}ms");
                Console.WriteLine($"Średni czas ruchu: {player.Times.Average()}ms");
                if(player.Algorithm.GetType() == typeof(AlphaBeta)) {
                    Console.WriteLine($"Najmniejsza liczba odcięć: {((AlphaBeta)player.Algorithm).CutoffsList.Min()}");
                    Console.WriteLine($"Średnia liczba odcięć: {((AlphaBeta)player.Algorithm).CutoffsList.Average()}");
                    Console.WriteLine($"Największa liczba odcięć: {((AlphaBeta)player.Algorithm).CutoffsList.Max()}");
                    Console.WriteLine($"Najmniejsza liczba wejść: {((AlphaBeta)player.Algorithm).NodeEntries.Min()}");
                    Console.WriteLine($"Średnia liczba wejść: {((AlphaBeta)player.Algorithm).NodeEntries.Average()}");
                    Console.WriteLine($"Największa liczba wejść: {((AlphaBeta)player.Algorithm).NodeEntries.Max()}");
                } else {
                    Console.WriteLine($"Najmniejsza liczba wejść: {((MinMax)player.Algorithm).NodeEntries.Min()}");
                    Console.WriteLine($"Średnia liczba wejść: {((MinMax)player.Algorithm).NodeEntries.Average()}");
                    Console.WriteLine($"Największa liczba wejść: {((MinMax)player.Algorithm).NodeEntries.Max()}");
                }
                Console.WriteLine();
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
            Console.ReadKey();
        }
    }
}
