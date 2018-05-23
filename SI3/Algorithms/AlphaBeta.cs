using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI3.Algorithms
{
    public class AlphaBeta : IAlgorithm
    {
        public Node ChoiceBestMove(Node root)
        {
            return AlphaBetaPruning(root, true, int.MinValue, int.MaxValue)
                .Children
                .Where(child => child.Value == root.Value)
                .FirstOrDefault();
        }


        public Node AlphaBetaPruning(Node node, bool maximizing, int alpha, int beta)
        {
            if (node.Children.Count == 0)
            {
                return node;
            }
            if (maximizing)
            {
                int bestValue = int.MinValue;
                foreach (Node child in node.Children)
                {
                    Node result = AlphaBetaPruning(child, !maximizing, alpha, beta);
                    bestValue = Math.Max(result.Value, bestValue);
                    alpha = Math.Max(alpha, bestValue);
                    if (beta <= alpha)
                        break;
                }
                node.Value = bestValue;
            }
            else
            {
                int bestValue = int.MaxValue;
                foreach (Node child in node.Children)
                {
                    Node result = AlphaBetaPruning(child, !maximizing, alpha, beta);
                    bestValue = Math.Min(result.Value, bestValue);
                    beta = Math.Min(alpha, bestValue);
                    if (beta <= alpha)
                        break;
                }
                node.Value = bestValue;
            }

            return node;
        }


    }
}
