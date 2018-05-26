using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI3.Algorithms
{
    public class AlphaBeta : IAlgorithm
    {
        public List<int> CutoffsList { get; private set; }
        public List<int> NodeEntries { get; private set; }
        int currentCutoffs;
        int currentEntries;

        public AlphaBeta() {
            CutoffsList = new List<int>();
            NodeEntries = new List<int>();
        }

        public Node ChoiceBestMove(Node root)
        {
            currentCutoffs = 0;
            currentEntries = 0;
            root = AlphaBetaPruning(root, true, int.MinValue, int.MaxValue);
            CutoffsList.Add(currentCutoffs);
            NodeEntries.Add(currentEntries);
            return root
                .Children
                .Where(child => child.Value == root.Value)
                .FirstOrDefault();
        }


        public Node AlphaBetaPruning(Node node, bool maximizing, int alpha, int beta)
        {
            currentEntries++;
            if (node.Children.Count == 0) {
                return node;
            }

            if (maximizing)
            {
                int bestValue = int.MinValue;
                foreach (Node child in node.Children)
                {
                    Node result = AlphaBetaPruning(child, false, alpha, beta);
                    bestValue = Math.Max(result.Value, bestValue);
                    alpha = Math.Max(alpha, bestValue);
                    if (beta <= alpha) {
                        currentCutoffs++;
                        break;
                    }                    
                }
                node.Value = bestValue;
            }
            else
            {
                int bestValue = int.MaxValue;
                foreach (Node child in node.Children)
                {
                    Node result = AlphaBetaPruning(child, true, alpha, beta);
                    bestValue = Math.Min(result.Value, bestValue);
                    beta = Math.Min(beta, bestValue);
                    if (beta <= alpha) {
                        currentCutoffs++;
                        break;
                    }
                }
                node.Value = bestValue;
            }

            return node;
        }

        public override string ToString() {
            return "Alfa-beta";
        }
    }
}
