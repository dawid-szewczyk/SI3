using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI3
{
    class Node
    {
        public Board Board { get; }
        public Tuple<int, int> PositionOnBoard { get; }
        public List<Node> Children { get; }
        public int Value { get; set; }
        public int Alpha { get; set; }
        public int Beta { get; set; }

        public Node(Board board, Tuple<int, int> positionOnBoard) {
            Board = new Board(board);
            PositionOnBoard = positionOnBoard;
            Children = new List<Node>();
            Alpha = int.MinValue;
            Beta = int.MaxValue;
        }

      

        public void AddChild(Node child) {
            Children.Add(child);
        }

        /*public void Visit() {
            foreach(Node child in Children) {
                child.Visit();
            }
        }*/
    }
}
