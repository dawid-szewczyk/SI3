using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI3.Algorithms
{
    public class MinMax : IAlgorithm
    {
        public List<int> NodeEntries { get; private set; }
        int currentEntries;

        public MinMax() {
            NodeEntries = new List<int>();
        }

        public Node ChoiceBestMove(Node root) {
            currentEntries = 0;
            Node node = MinMaxFunction(root, true);
            NodeEntries.Add(currentEntries);
            return node
                .Children
                .Where(child => child.Value == root.Value)
                .FirstOrDefault();
        }

        Node MinMaxFunction(Node node, bool maximizing) {
            currentEntries++;
            if(node.Children.Count == 0) {
                return node;
            }

            if (maximizing) {
                int bestValue = int.MinValue;
                foreach(Node child in node.Children) {
                    Node result = MinMaxFunction(child, false);
                    bestValue = Math.Max(result.Value, bestValue);
                }
                node.Value = bestValue;
            } else {
                int bestValue = int.MaxValue;
                foreach (Node child in node.Children) {
                    Node result = MinMaxFunction(child, true);
                    bestValue = Math.Min(result.Value, bestValue);
                }
                node.Value = bestValue;
            }

            return node;
        }

        public override string ToString() {
            return "Min-max";
        }
    }
}
