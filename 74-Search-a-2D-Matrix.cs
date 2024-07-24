public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        for (var i =0; i < matrix.Length; i++)
        {
            for (var j =0; j < matrix[i].Length; j++)
            {
                if(matrix[i][j] == target)
                {
                    return true;
                }
            }
        }
        return false;
    }
}