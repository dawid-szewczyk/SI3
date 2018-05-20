using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI3.Algorithm
{
    class AlphaBeta : IAlgorithm
    {
        public Node ChoiceBestMove(Node root)
        {
            return MaxValueNode(root)
                .Children
                .Where(child => child.Value == root.Value)
                .FirstOrDefault();
        }

        //Beta - minimizer
        //Alfa - maximizer

        public Node MinValueNode(Node curNode)
        {
            curNode.Value = int.MaxValue;

            if (curNode.isLeaf())
                return curNode;
            foreach (var child in curNode.Children)
            {
                Node resultNode = MaxValueNode(child);
                if (resultNode.Value < curNode.Value)
                    curNode.Value = resultNode.Value;

                if (resultNode.Value <= curNode.Alpha)
                    return curNode;

                if (resultNode.Value < curNode.Beta)
                    curNode.Beta = resultNode.Value;

                
            }
            return curNode;
        }

        public Node MaxValueNode(Node curNode)
        {
            curNode.Value = int.MinValue;
            if (curNode.isLeaf())
                return curNode;
            foreach (var child in curNode.Children)
            {
                Node resultNode = MinValueNode(child);
                if (resultNode.Value > curNode.Value)
                    curNode.Value = resultNode.Value;

                if (resultNode.Value >= curNode.Beta)
                    return curNode;

                if (resultNode.Value > curNode.Alpha)
                    curNode.Alpha = resultNode.Alpha;

                

            }
            return curNode;
        }



        // Node AlphaBetaFunction(Node node, bool maximizing, int alpha,int beta)
        //{
        //    if (node.Children.Count == 0)
        //        return node;
        //    //Jeżeli rusza się przeciwnik to dla każdego węzła szukamy bety (minimum)
        //    if(!maximizing)
        //    {
        //        foreach(var child in node.Children)
        //        {
        //            int resultNodeValue = Math.Min(node.Value,AlphaBetaFunction(child, true, alpha, beta).Value);
        //            beta = Math.Min(beta, resultNodeValue);
        //            if (alpha >= beta)
        //            {
        //                node.Beta = beta;
        //                node.Value = beta;
        //                return node;
        //            }
        //        }
        //    }
        //    else
        //    {
        //        foreach (var child in node.Children)
        //        {
        //            int resultNodeValue = Math.Max(node.Value, AlphaBetaFunction(child, false, alpha, beta).Value);
        //            alpha = Math.Max(alpha, resultNodeValue);
        //            if (alpha >= beta)
        //            {
        //                node.Alpha = alpha;
        //                node.Value = alpha;
        //                return node;
        //            }
        //        }
        //    }
        //    return node;
        //}
    }
}
