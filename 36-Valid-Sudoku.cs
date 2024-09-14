public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<char> set = new();

        int length = board.Length;
        char current;

        for (int i = 0; i < length; i++)
        {
            for (int j = 0; j < length; j++)
            {
                current = board[i][j];
                
                if (current == '.') continue;
                
                if (set.Contains(current)) return false;

                set.Add(current);
            }

            set.Clear();
        }

        for (int i = 0; i < length; i++)
        {
            for (int j = 0; j < length; j++)
            {
                current = board[j][i];
                
                if (current == '.') continue;

                if (set.Contains(current)) return false;

                set.Add(current);
            }

            set.Clear();
        }

        int subLength = length / 3;

        for (int i = 0; i < subLength; i++)
        {
            for (int j = 0; j < subLength; j++)
            {
                for (int k = 0; k < subLength; k++)
                {
                    for (int l = 0; l < subLength; l++)
                    {
                        current = board[i * 3 + k][j * 3 + l];
                        
                        if (current == '.') continue;

                        if (set.Contains(current)) return false;

                        set.Add(current);
                    }
                }
                
                set.Clear();
            }
        }

        return true;
    }
}