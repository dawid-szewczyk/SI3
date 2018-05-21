using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI3
{
    public class HumanPlayer : Player
    {
        public HumanPlayer(int color) {
            Color = color;
        }

        public override Tuple<int, int> ChooseMove(Board board) {
            Tuple<int, int> move = null;
            while (move == null) {
                Console.WriteLine("Podaj współrzędne ruchu:");
                string[] data = Console.ReadLine().Split(' ');
                try {
                    int row = Int32.Parse(data[0]);
                    int column = Int32.Parse(data[1]);
                    if (board.IsFieldEmpty(row, column)) {
                        move = new Tuple<int, int>(row, column);
                    }
                    else {
                        Console.WriteLine("Wybrane pole jest zajęte!");
                    }
                }
                catch (Exception) {
                    Console.WriteLine("Musisz podać dwie współrzędne tablicy indeksowane od zera. Wierzę, że teraz dasz radę!");
                }
            }
            return move;
        }
    }
}
