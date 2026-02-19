using SharedProject.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAndAlgorithms.HashMapAndSet;

public static class ZeroStriping
{
    public static void SetZeroes(int[][] matrix)
    {
        if (matrix.IsNullOrEmpty())
        {
            return;
        }

        int rows = matrix.Length;
        int cols = matrix[0].Length;

        bool firstRowZero = false;
        bool firstColZero = false;

        // Step 1: Check if first row has zero
        for (int j = 0; j < cols; j++)
        {
            if (matrix[0][j] == 0)
            {
                firstRowZero = true;
                break;
            }
        }

        // Step 2: Check if first column has zero
        for (int i = 0; i < rows; i++)
        {
            if (matrix[i][0] == 0)
            {
                firstColZero = true;
                break;
            }
        }

        // Step 3: Use first row & column as markers
        for (int i = 1; i < rows; i++)
        {
            for (int j = 1; j < cols; j++)
            {
                if (matrix[i][j] == 0)
                {
                    matrix[i][0] = 0;
                    matrix[0][j] = 0;
                }
            }
        }

        // Step 4: Set cells to zero based on markers
        for (int i = 1; i < rows; i++)
        {
            for (int j = 1; j < cols; j++)
            {
                if (matrix[i][0] == 0 || matrix[0][j] == 0)
                {
                    matrix[i][j] = 0;
                }
            }
        }

        // Step 5: Zero out first row if needed
        if (firstRowZero)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[0][j] = 0;
            }
        }

        // Step 6: Zero out first column if needed
        if (firstColZero)
        {
            for (int i = 0; i < rows; i++)
            {
                matrix[i][0] = 0;
            }
        }
    }
}
