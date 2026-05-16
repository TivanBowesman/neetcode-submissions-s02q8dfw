public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        //decide the min amount of bannas needed to eat the pile

        //at minimum you want to consume the min num of bananna
        int min = 1; 

        int max = piles.Max();
        int res = int.MaxValue;

        while(min <= max){
            int k = min + (max - min) / 2; 
            
            int hoursLeft = h;

            foreach (var banana in piles) {
                //
            hoursLeft -= (banana + k - 1) / k;
            }

            if(hoursLeft >= 0){
                //register the speed 
                res = Math.Min(res, k);
                max = k - 1;
            }else{
                min = k + 1;
            }
        }


        return res;
    }
}
