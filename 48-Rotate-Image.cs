public class Solution 
{
    public void Rotate(int[][] matrix)
    {
        // First, transpose the matrix
        Transpose(matrix);

        // Then, reverse each row to get the rotated matrix
        ReverseRows(matrix);
    }

    private void Transpose(int[][] matrix)
    {
        int n = matrix.Length;

        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                // Swap the elements at (i, j) and (j, i)
                int temp = matrix[i][j];
                matrix[i][j] = matrix[j][i];
                matrix[j][i] = temp;
            }
        }
    }

    private void ReverseRows(int[][] matrix)
    {
        int n = matrix.Length;

        for (int i = 0; i < n; i++)
        {
            // Reverse each row
            Array.Reverse(matrix[i]);
        }
    }
}