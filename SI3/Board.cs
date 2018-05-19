using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI3
{
    public class Board
    {
        int[][] board;
        int size;

        public Board(int size) {
            this.size = size;
            board = new int[size][];
            for (int i = 0; i < size; i++) {
                board[i] = new int[size];
            }
        }

        public Board(Board other) : this(other.size) {
            board = other.board.Select(s => s.ToArray()).ToArray();
        }

        public Board(Board other, Tuple<int, int> newPosition) : this(other) {
            board[newPosition.Item1][newPosition.Item2] = 1;
        }

        public int CalculatePointsGain(int chosenRow, int chosenColumn) {
            int points = 0;
            int i, j;

            // Czy punkt uzupełnił wiersz
            i = 0;
            while(i < size && board[chosenRow][i] != 0) {
                i++;
            }
            if(i == size) {
                points += size;
            }

            // Czy punkt uzupełnił kolumnę
            i = 0;
            while (i < size && board[i][chosenColumn] != 0) {
                i++;
            }
            if (i == size) {
                points += size;
            }

            // Czy punkt uzupełnił przekątną góra-lewo dół-prawo
            int fields = 0;
            int chosenFields = 0;
            i = chosenRow - Math.Min(chosenRow, chosenColumn);
            j = chosenColumn - Math.Min(chosenRow, chosenColumn);
            while (i < size && j < size) {
                if (board[i][j] != 0) {
                    chosenFields++;
                }
                i++;
                j++;
                fields++;             
            }
            if(fields > 1 && fields == chosenFields) {
                points += chosenFields;
            }

            // Czy punkt uzupełnił przekątną dół-lewo góra-prawo
            fields = 0;
            chosenFields = 0;
            int diff = Math.Min(size - 1 - chosenRow, chosenColumn);
            i = chosenRow + diff;
            j = chosenColumn - diff;
            while(i > 0 && j < size) {
                if (board[i][j] != 0) {
                    chosenFields++;
                }
                i--;
                j++;
                fields++;              
            }
            if(fields > 1 && fields == chosenFields) {
                points += chosenFields;
            }

            return points;
        }

        public void SetPoint(int row, int column, int value) {
            board[row][column] = value;
        }

        public List<Tuple<int, int>> GetAvailableMoves() {
            List<Tuple<int, int>> result = new List<Tuple<int, int>>();
            for (int i = 0; i < size; i++) {
                for (int j = 0; j < size; j++) {
                    if (board[i][j] == 0) {
                        result.Add(new Tuple<int, int>(i, j));
                    }
                }
            }
            return result;
        }

        public bool IsFieldEmpty(int chosenRow, int chosenColumn) {
            return board[chosenRow][chosenColumn] == 0;
        }

        public void Print() {
            for (int i = 0; i < size; i++) {
                for (int j = 0; j < size; j++) {
                    Console.Write(board[i][j] + " ");
                }
                Console.Write("\n");
            }
        }
    }
}
