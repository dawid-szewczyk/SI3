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
            Node node = AlphaBetaFunction(root, true, int.MinValue, int.MaxValue);
            Console.WriteLine("Root value: " + root.Value);
            foreach (Node child in node.Children) {
                Console.WriteLine("Child value: " + child.Value);
            }
            return node.Children
                .Where(child => child.Value == root.Value)
                .FirstOrDefault();

            /*return AlphaBetaFunction(root, true, int.MinValue, int.MaxValue)
                .Children
                .Where(child => child.Value == root.Value)
                .FirstOrDefault();*/
        }

        Node AlphaBetaFunction(Node node, bool maximizing, int alpha, int beta) {
            if (node.Children.Count == 0) {
                return node;
            }

            if (maximizing) {
                foreach (Node child in node.Children) {
                    alpha = Math.Max(alpha, AlphaBetaFunction(child, false, alpha, beta).Value);
                    if(alpha >= beta) {
                        break;
                    }
                }
                node.Value = beta;
            }
            else {
                foreach (Node child in node.Children) {
                    beta = Math.Min(beta, AlphaBetaFunction(child, false, alpha, beta).Value);
                    if(alpha >= beta) {
                        break;
                    }
                }
                node.Value = alpha;
            }

            return node;
        }
    }
}
