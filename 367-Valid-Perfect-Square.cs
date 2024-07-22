public class Solution {
    public bool IsPerfectSquare(int num) {
        double x = Math.Sqrt(num);
        int i = (int)Math.Sqrt(num);
        if(x - i == 0)
        {
            return true;
        }
        else{
            return false;
        }
    }
}