using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAndAlgorithms.HashMapAndSet;

public static class VerifySudokuBoard
{
    public static bool IsValidSudoku(int[][] board)
    {
        HashSet<int>[] rows = new HashSet<int>[9];
        HashSet<int>[] cols = new HashSet<int>[9];
        HashSet<int>[] boxes = new HashSet<int>[9];

        for (int i = 0; i < 9; i++)
        {
            rows[i] = new HashSet<int>();
            cols[i] = new HashSet<int>();
            boxes[i] = new HashSet<int>();
        }

        for (int r = 0; r < 9; r++)
        {
            for (int c = 0; c < 9; c++)
            {
                int val = board[r][c];

                if (val == 0)
                    continue;

                // Optional safety check
                if (val < 1 || val > 9)
                    return false;

                int boxIndex = (r / 3) * 3 + (c / 3);

                if (rows[r].Contains(val) ||
                    cols[c].Contains(val) ||
                    boxes[boxIndex].Contains(val))
                {
                    return false;
                }

                rows[r].Add(val);
                cols[c].Add(val);
                boxes[boxIndex].Add(val);
            }
        }

        return true;
    }
}
