using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI3
{
    public class Node
    {
        public Tuple<int, int> PositionOnBoard { get; }
        public List<Node> Children { get; private set; }
        public int Value { get; set; }

        public Node(Tuple<int, int> positionOnBoard) {
            PositionOnBoard = positionOnBoard;
            Children = new List<Node>();
        }      

        public void AddChild(Node child) {
            Children.Add(child);
        }

        public void Visit() {
            if (PositionOnBoard != null) { 
                Console.WriteLine($"Pozycja: {PositionOnBoard.Item1}, {PositionOnBoard.Item2}. Wartość: {Value}");
            }

            foreach(Node child in Children) {
                child.Visit();
            }
        }

        public void SortChildrenByValueDesc() {
            Children = Children.OrderByDescending(child => child.Value).ToList();
        }

        public void SortChildrenByValue() {
            Children = Children.OrderBy(child => child.Value).ToList();
        }
    }
}
