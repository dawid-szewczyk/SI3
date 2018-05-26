﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI3.Heuristics.NodeChoice
{
    public interface INodeChoice
    {
        Node ChooseNode(AIPlayer player);
    }
}
