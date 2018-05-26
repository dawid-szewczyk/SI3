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
    public class AIPlayer : Player
    {
        public int TreeDepth { get; private set; }
        public Board CurrentBoard { get; private set; }
        public Player Opponent { set; get; }
        public IGameState GameStateCalculator { get; }
        public INodeChoice NodeSelector { get; }
        public IAlgorithm Algorithm { get; }    
        public List<long> Times { get; private set; }

        public AIPlayer(int color, int treeDepth, IGameState gameStateCalculator, INodeChoice nodeSelector, IAlgorithm algorithm, Board board) {
            Color = color;
            Points = 0;
            TreeDepth = treeDepth;
            GameStateCalculator = gameStateCalculator;
            Algorithm = algorithm;
            Board = board;
            NodeSelector = nodeSelector ?? new StandardSelector();
            Times = new List<long>();
        }

        public override Tuple<int, int> ChooseMove() {
            CurrentBoard = new Board(Board);
            Node root = NodeSelector.ChooseNode(this);
            Stopwatch stopwatch = Stopwatch.StartNew();
            Tuple<int, int> chosenMove = Algorithm.ChoiceBestMove(root).PositionOnBoard;
            stopwatch.Stop();
            Times.Add(stopwatch.ElapsedMilliseconds);
            return chosenMove;
        }      
    }
}
