using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI3
{
    public abstract class Player
    {
        public Board Board { get; protected set; }
        public int Points { get; protected set; }
        public int Color { get; protected set; }

        public abstract Tuple<int, int> ChooseMove();
        public void AddPoints(int points) {
            Points += points;
        }
    }
}
