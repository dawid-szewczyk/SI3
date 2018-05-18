using SI3.Algorithm;
using SI3.Heuristics.GameState;
using SI3.Heuristics.NodeChoice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI3
{
    class AIPlayer : Player
    {
        int treeDepth;
        IGameState gameStateCalculator;
        INodeChoice nodeSelector;
        IAlgorithm algorithm;

        public AIPlayer(int color, int treeDepth, IGameState gameStateCalculator, INodeChoice nodeSelector, IAlgorithm algorithm) {
            Color = color;
            Points = 0;
            this.treeDepth = treeDepth;
            this.gameStateCalculator = gameStateCalculator;
            this.nodeSelector = nodeSelector;
            this.algorithm = algorithm;
        }

        public override Tuple<int, int> ChooseMove(Board board) {
            Node root = BuildTree(board, null, 0);
            SetLeafsValues(root);
            return algorithm.ChoiceBestMove(root).PositionOnBoard;
        }

        Node BuildTree(Board board, Tuple<int, int> positionOnBoard, int currentDepth) {
            Node node = new Node(board, positionOnBoard);

            if(currentDepth < treeDepth) {
                foreach (Tuple<int, int> move in board.GetAvailableMoves()) {
                    Board boardAfterMove = new Board(board, move);
                    Node child = BuildTree(boardAfterMove, move, currentDepth + 1);
                    node.AddChild(child);
                }
            }
            return node;
        } 

        void SetLeafsValues(Node node) {
            if(node.Children.Count == 0) {
                node.Value = gameStateCalculator.Calculate(node.Board, node.PositionOnBoard);
            } else {
                foreach(Node child in node.Children) {
                    SetLeafsValues(child);
                }
            }
        }
    }
}
