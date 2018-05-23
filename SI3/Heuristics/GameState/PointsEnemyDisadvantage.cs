using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI3.Heuristics.GameState
{
    class PointsEnemyDisadvantage :IGameState
    {
        public int Calculate(Board board, List<Tuple<int, int, int>> movesSequence, Player player, Player opponent)
        {
            int result = 0;
            Board movesBoard = new Board(board);
            for(int i=0;i<movesSequence.Count-1;i++)
            {
                movesBoard.SetPoint(movesSequence[i].Item1, movesSequence[i].Item2, movesSequence[i].Item3);
                int pointsChange = movesBoard.CalculatePointsGain(movesSequence[i].Item1, movesSequence[i].Item2);
                int pointsChange2= movesBoard.CalculatePointsGain(movesSequence[i+1].Item1, movesSequence[i+1].Item2);
                if (movesSequence[i].Item3 == opponent.Color)
                    if (pointsChange > pointsChange2)
                        result -= pointsChange;
                    else
                        result += pointsChange;
                else
                    result += pointsChange;
                  
            }


            return result;
        }
    }
}
