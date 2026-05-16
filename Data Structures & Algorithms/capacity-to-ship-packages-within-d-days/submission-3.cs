public class Solution {
    public int ShipWithinDays(int[] weights, int days) {
        //(a,b) => b.CompareTo(a)
        if(weights.Length == days) return weights.Max();
        //the min has to be that maximum (wouldnt be able to carry it otherwise)

        int min = weights.Max();
        //max is the sum of all weights on the boat
        int max = weights.Sum();

        // get min weight to carry out within x days
        int res = int.MaxValue;

        while(min <= max){
            int mid = min + (max - min) / 2;
            int currSum = 0;
            int daysLeft = days;
            bool canFit = false;
            //check if the weight can be held with the mid
            for(int i = 0; i < weights.Length; i++){
                if(weights[i] + currSum > mid){
                    daysLeft --;
                    currSum = 0;
                }
                
                currSum += weights[i];

                if(i == weights.Length - 1 && daysLeft > 0 ){
                    canFit = true;
                }
            }

            if(canFit){
                res = Math.Min(res, mid);
                //decrease to find smaller
                max = mid - 1;
            }else{
                //allow more to fit in the ships
                min = mid + 1;
            }
        }

        return res;
    }
}