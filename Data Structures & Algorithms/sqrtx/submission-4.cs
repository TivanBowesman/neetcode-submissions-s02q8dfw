public class Solution {
    public int MySqrt(int x) {
        int l = 1;
        int r = x; 
        int res = 0;
        while(l <= r){
            var mid = l + (r - l ) / 2;

            long sum = (long)mid * mid;
            if(sum == x){
                return mid;
            }else if (sum < x){
                l = mid + 1;
                res = mid;
            }else{
                r = mid - 1;
            }
        }

        return res;
    }
}