class Solution {
    public int longestConsecutive(int[] nums) {
        //check if minus 1 is in it 
        Set<Integer> hashset = new HashSet<>();
        for(int num: nums){
            hashset.add(num);
        }

        int max = 0; 
        for(int num : hashset){
            //go to beginning 
            if(!hashset.contains(num -1)){
                //1 num is 0
                int curr = num; 
                int sum = 0; 
                while(hashset.contains(curr )){
                    sum++;
                    curr ++;
                }

                max = Math.max(max, sum);
            }
        }

        return max;
    }
}
