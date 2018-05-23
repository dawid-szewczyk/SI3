using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI3.Heuristics.NodeChoice
{
    class OuterToInner : INodeChoice
    {
        public List<Tuple<int, int>> ChooseNode(Board board)
        {

            List<Tuple<int, int>> result = new List<Tuple<int, int>>();
            int i, k = 0, l = 0;
            /* k - starting row index
            m - ending row index
            l - starting column index
            n - ending column index
            i - iterator
            */
            int m = board.size;
            int n = board.size;
            while (k < m && l < n)
            {
                for (i = l; i < n; ++i)
                {
                    if (board.board[k][i] == 0)
                    {
                        result.Add(new Tuple<int, int>(k, i));
                    }
                }
                k++;
                for (i = k; i < m; ++i)
                {
                    if (board.board[i][n-1] == 0)
                    {
                        result.Add(new Tuple<int, int>(i, n-1));
                    }
                }
                n--;
                if (k < m)
                {
                    for (i = n - 1; i >= l; --i)
                    {
                        if (board.board[m-1][i] == 0)
                        {
                            result.Add(new Tuple<int, int>(m-1, i));
                        }
                    }
                    m--;
                }
                if (l < n)
                {
                    for (i = m - 1; i >= k; --i)
                    {
                        if (board.board[i][l] == 0)
                        {
                            result.Add(new Tuple<int, int>(i, l));
                        }
                    }
                    l++;
                }
            }
            return result;


        }

       
        
    }
}
