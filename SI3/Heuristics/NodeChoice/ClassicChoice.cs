using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI3.Heuristics.NodeChoice
{
    class ClassicChoice : INodeChoice
    {
        
        public List<Tuple<int, int>> ChooseNode(Board board)
        {
            
                List<Tuple<int, int>> result = new List<Tuple<int, int>>();
                for (int i = 0; i < board.size; i++)
                {
                    for (int j = 0; j < board.size; j++)
                    {
                        if (board.board[i][j] == 0)
                        {
                            result.Add(new Tuple<int, int>(i, j));
                        }
                    }
                }
                return result;
            
        }
    }
}
