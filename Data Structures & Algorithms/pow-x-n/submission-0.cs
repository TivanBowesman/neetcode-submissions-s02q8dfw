public class Solution {
    public double MyPow(double x, int n) {
        if (n == 0) return 1;

        double sum = x;
        for (int i = 1; i < Math.Abs(n); i++){
            sum *= x;
        }
        if(n < 0){
           return 1/sum;
        }

        return sum;
    }
}
