public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        //return int array of num1,num2
        //use binary search since its sorted

        int l = 0;
        int r = numbers.Length - 1;

        while(l < r){
            var sum = numbers[l] + numbers[r]; 

            if (sum == target){
                return new int[]{l+1, r+1};
            }else if(sum < target){
                l++;
            }else{
                r--;
            }
        }

        return new int[]{};
    }
}
