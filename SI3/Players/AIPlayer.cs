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
        Board currentBoard;
        public Player Opponent { set; get; }
        public IGameState GameStateCalculator { get; }
        public INodeChoice NodeSelector { get; }
        public IAlgorithm Algorithm { get; }       

        public AIPlayer(int color, int treeDepth, IGameState gameStateCalculator, INodeChoice nodeSelector, IAlgorithm algorithm, Board board) {
            Color = color;
            Points = 0;
            this.treeDepth = treeDepth;
            GameStateCalculator = gameStateCalculator;
            NodeSelector = nodeSelector;
            Algorithm = algorithm;
            Board = board;
        }

        public override Tuple<int, int> ChooseMove() {
            currentBoard = new Board(Board);
            Node root = BuildTree(new List<Tuple<int, int, int>>(), 0, true);

            //root.Visit();

            return Algorithm.ChoiceBestMove(root).PositionOnBoard;
        }

        Node BuildTree(List<Tuple<int, int, int>> movesSequence, int currentDepth, bool isPlayerMoving) {
            Node node;
            if (movesSequence.Count > 0) {
                node = new Node(new Tuple<int, int>(movesSequence.Last().Item1, movesSequence.Last().Item2));
            } else {
                node = new Node(null);
            }

            List<Tuple<int, int>> availableMoves = Board.GetAvailableMoves();
            if (currentDepth < treeDepth && availableMoves.Count > 0) {
                foreach (Tuple<int, int> move in availableMoves) {
                    int color = isPlayerMoving ? Color : Opponent.Color;
                    Tuple<int, int, int> moveWithColor = new Tuple<int, int, int>(move.Item1, move.Item2, color);
                    movesSequence.Add(moveWithColor);

                    Board.SetPoint(move.Item1, move.Item2, color);
                    Node child = BuildTree(movesSequence, currentDepth + 1, !isPlayerMoving);
                    node.AddChild(child);

                    movesSequence.Remove(moveWithColor);
                    Board.SetPoint(move.Item1, move.Item2, 0);
                }
            }
            else {
                node.Value = GameStateCalculator.Calculate(currentBoard, movesSequence, this, Opponent);
            }
            return node;
        }
    }
}
