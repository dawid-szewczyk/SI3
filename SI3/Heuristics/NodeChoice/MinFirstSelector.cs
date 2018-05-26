using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI3.Heuristics.NodeChoice
{
    public class MinFirstSelector : INodeChoice
    {
        AIPlayer player;

        public Node ChooseNode(AIPlayer player) {
            this.player = player;
            return BuildTree(new List<Tuple<int, int, int>>(), 0, true);
        }

        Node BuildTree(List<Tuple<int, int, int>> movesSequence, int currentDepth, bool isPlayerMoving) {
            Node node;
            if (movesSequence.Count > 0) {
                node = new Node(new Tuple<int, int>(movesSequence.Last().Item1, movesSequence.Last().Item2));
            }
            else {
                node = new Node(null);
            }

            List<Tuple<int, int>> availableMoves = player.Board.GetAvailableMoves();
            if (currentDepth < player.TreeDepth && availableMoves.Count > 0) {
                int sum = 0;
                foreach (Tuple<int, int> move in availableMoves) {
                    int color = isPlayerMoving ? player.Color : player.Opponent.Color;
                    Tuple<int, int, int> moveWithColor = new Tuple<int, int, int>(move.Item1, move.Item2, color);
                    movesSequence.Add(moveWithColor);

                    player.Board.SetPoint(move.Item1, move.Item2, color);
                    Node child = BuildTree(movesSequence, currentDepth + 1, !isPlayerMoving);
                    node.AddChild(child);
                    sum += child.Value;

                    movesSequence.Remove(moveWithColor);
                    player.Board.SetPoint(move.Item1, move.Item2, 0);
                }
                node.Value = sum;
                node.SortChildrenByValue();
            }
            else {
                node.Value = player.GameStateCalculator.Calculate(player.CurrentBoard, movesSequence, player, player.Opponent);
            }
            return node;
        }

        public override string ToString() {
            return "Najmniejsze wart. pierwsze";
        }
    }
}

