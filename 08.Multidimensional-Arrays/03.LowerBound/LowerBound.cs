/*3. We are given a matrix of strings of size N x M. Sequences in the matrix we define 
 *as sets of several neighbor elements located on the same line, column or diagonal. 
  *Write a program that finds the longest sequence of equal strings in the matrix.*/
using System;
using System.Text;

class LowerBound
{
    static void Main()
    {
        string[,] matrix = 
		{ 
			{ "ha", "fifi", "ho", "hi" }, 
			{ "fo", "ha", "hi", "xx" }, 
			{ "xxx", "ho", "ha", "xx" } 
		};
        int nrows = matrix.GetLength(0);// x = 3
        int ncols = matrix.GetLength(1);// y = 4
        int ndiagonal = ncols + nrows - 1;// diagonal = 6
        int AllBestLen = 1;
        string AllBestLenElement = "";
        // check rows
        for (int row = 0; row < nrows; row++)
        {
            string[] matrixX = new string[ncols];
            for (int col = 0; col < ncols; col++)
            {
                matrixX[col] = matrix[row, col];
            }
            int bestLen = BestLen(matrixX);
            string bestLenElement = BestLenElement(matrixX);
            if (bestLen > AllBestLen)
            {
                AllBestLen = bestLen;
                AllBestLenElement = bestLenElement;
            }
        }
        // check cols
        for (int col = 0; col < ncols; col++)
        {
            string[] matrixY = new string[nrows];
            for (int row = 0; row < nrows; row++)
            {
                matrixY[row] = matrix[row, col];
            }
            int bestLen = BestLen(matrixY);
            string bestLenElement = BestLenElement(matrixY);
            if (bestLen > AllBestLen)
            {
                AllBestLen = bestLen;
                AllBestLenElement = bestLenElement;
            }
        }
        // check diagonals
        string[] diagonals = Diagonals(matrix);
        for (int i = 0; i < diagonals.Length; i++)
        {
            string[] splitDiagonals = diagonals[i].Split(' ');
            int bestLen = BestLen(splitDiagonals);
            string bestLenElement = BestLenElement(splitDiagonals);
            if (bestLen > AllBestLen)
            {
                AllBestLen = bestLen;
                AllBestLenElement = bestLenElement;
            }
        }
        for (int i = 0; i < AllBestLen; i++)
        {
            Console.Write("{0};", AllBestLenElement);
        }
        Console.WriteLine();
    }
    static string[] Diagonals(string[,] grid)
    {
        int nrows = grid.GetLength(0);
        int ncols = grid.GetLength(1);
        int nwords = ncols + nrows - 1;
        string[] words = new string[nwords];
        int row = 0;
        int col = ncols - 1;
        StringBuilder sb = new StringBuilder();
        for (int iword = 0; iword < nwords; ++iword)
        {
            int n = Math.Min(nrows - row, ncols - col);
            for (int i = 0; i < n; ++i)
            {
                sb.Append(grid[row + i, col + i]);
                sb.Append(" ");
            }
            words[iword] = sb.ToString();
            sb.Clear();
            if (col > 0)
            {
                --col;
            }
            else
            {
                ++row;
            }
        }
        return words;
    }
    static string BestLenElement(string[] array)
    {
        int n = array.Length;
        int start = 0;
        int len = 1;
        int bestStart = 0, bestLen = 1;
        string bestLenElement = "";
        for (int i = 1; i < n; i++)
        {
            if (array[i] == array[i - 1])
            {
                start = i;
                len++;
                if (bestLen < len)
                {
                    bestStart = start;
                    bestLen = len;
                    bestLenElement = array[start];
                }
            }
            else
            {
                len = 1;
            }
        }
        if (len > bestLen)
        {
            bestLen = len;
            bestLenElement = array[n - 1];
        }
        return bestLenElement;
    }
    static int BestLen(string[] array)
    {
        int n = array.Length;
        int start = 0;
        int len = 1;
        int bestStart = 0, bestLen = 1;
        string bestLenElement = "";
        for (int i = 1; i < n; i++)
        {
            if (array[i] == array[i - 1])
            {
                start = i;
                len++;
                if (bestLen < len)
                {
                    bestStart = start;
                    bestLen = len;
                    bestLenElement = array[start];
                }
            }
            else
            {
                len = 1;
            }
        }
        if (len > bestLen)
        {
            bestLen = len;
            bestLenElement = array[n - 1];
        }
        return bestLen;
    }
}