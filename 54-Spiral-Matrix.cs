public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) {
        var list = new List<int>();
        var n = matrix.Length;
        int top = 0, bottom = n - 1, left = 0, right = matrix[0].Length - 1;
        while(true){
            for (int i = left; i <= right; i++)
                list.Add(matrix[top][i]);
            top++;
            if (top > bottom || left > right) break;

            for (int i = top; i <= bottom; i++)
                list.Add(matrix[i][right]);
            right--;
            if (top > bottom || left > right) break;
            
            for (int i = right; i >= left; i--)
                list.Add(matrix[bottom][i]);
            bottom--;
            if (top > bottom || left > right) break;

            for (int i = bottom; i >= top; i--)
                list.Add(matrix[i][left]);
            left++;            
            if (top > bottom || left > right) break;
        }
        return list;
    }
}