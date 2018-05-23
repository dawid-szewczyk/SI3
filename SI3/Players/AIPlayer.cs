using SI3.Algorithms;
using SI3.Heuristics.GameState;
using SI3.Heuristics.NodeChoice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI3
{
    public class AIPlayer : Player
    {
        int treeDepth;
        public Player Opponent { set; get; }
        public IGameState GameStateCalculator { get; }
        public INodeChoice NodeSelector { get; }
        public IAlgorithm Algorithm { get; }       

        public AIPlayer(int color, int treeDepth, IGameState gameStateCalculator, INodeChoice nodeSelector, IAlgorithm algorithm) {
            Color = color;
            Points = 0;
            this.treeDepth = treeDepth;
            GameStateCalculator = gameStateCalculator;
            NodeSelector = nodeSelector;
            Algorithm = algorithm;
        }

        public override Tuple<int, int> ChooseMove(Board board) {
            Node root = BuildTree(board, null, 0);
            return Algorithm.ChoiceBestMove(root).PositionOnBoard;
        }

        Node BuildTree(Board board, Tuple<int, int> positionOnBoard, int currentDepth) {
            Node node = new Node(positionOnBoard);

            if (currentDepth < treeDepth) {
                foreach (Tuple<int, int> move in board.GetAvailableMoves()) {
                    board.SetPoint(move.Item1, move.Item2, 1);
                    Node child = BuildTree(board, move, currentDepth + 1);
                    node.AddChild(child);
                    board.SetPoint(move.Item1, move.Item2, 0);
                }
            }
            else {
                node.Value = GameStateCalculator.Calculate(board, node.PositionOnBoard, this, Opponent);
            }
            return node;
        }
    }
}
