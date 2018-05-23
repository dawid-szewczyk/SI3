﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI3.Heuristics.GameState
{
    public interface IGameState
    {
        int Calculate(Board board, Tuple<int, int> move, Player player, Player opponent);
    }
}
