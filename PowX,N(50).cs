public class Solution {
    public double MyPow(double x, int n) {
        
        if(x == 1 || n == 0)
            return 1;
        if(x == 0)
            return 0;
        if(n == 1)
            return x;
        
        if(n < 0)
            return 1/x * MyPow(1/x, -(n+1));

        if(n % 2 == 0)
            return MyPow((x * x), n/2);
        else
            return x * MyPow((x * x), n/2);
            
        return -1;
    }
}