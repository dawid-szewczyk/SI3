﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI3.Algorithms
{
    public interface IAlgorithm
    {
        Node ChoiceBestMove(Node root);
    }
}