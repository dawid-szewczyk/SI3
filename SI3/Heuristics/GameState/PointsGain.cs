﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI3.Heuristics.GameState
{
    public class PointsGain : IGameState
    {
        public int Calculate(Board board, Tuple<int, int> move, Player player, Player opponent) {
            return board.CalculatePointsGain(move.Item1, move.Item2);
        }

        public override string ToString() {
            return "Zysk punktowy";
        }
    }
}
