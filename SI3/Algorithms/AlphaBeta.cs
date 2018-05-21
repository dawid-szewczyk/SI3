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
            Console.WriteLine(AlphaBetaFunction(root, true, root.Alpha, root.Beta)
                .Children
                .Where(child => child.Value == root.Value)
                .FirstOrDefault() == null);
            return AlphaBetaFunction(root, true, root.Alpha, root.Beta)
                .Children
                .Where(child => child.Value == root.Value)
                .FirstOrDefault();
        }

        Node AlphaBetaFunction(Node node, bool maximizing, int alpha, int beta)
        {
            if (node.Children.Count == 0) {
                return node;
            }

            //Jeżeli rusza się przeciwnik to dla każdego węzła szukamy bety (minimum)
            if(!maximizing)
            {
                foreach(var child in node.Children)
                {
                    int resultNodeValue = Math.Min(node.Value,AlphaBetaFunction(child, true, alpha, beta).Value);
                    beta = Math.Min(beta, resultNodeValue);
                    if (alpha >= beta)
                    {
                        node.Beta = beta;
                        node.Value = beta;
                        return node;
                    }
                }
            }
            else
            {
                foreach (var child in node.Children)
                {
                    int resultNodeValue = Math.Max(node.Value, AlphaBetaFunction(child, false, alpha, beta).Value);
                    alpha = Math.Max(alpha, resultNodeValue);
                    if (alpha >= beta)
                    {
                        node.Alpha = alpha;
                        node.Value = alpha;
                        return node;
                    }
                }
            }
            return node;
        }
    }
}
