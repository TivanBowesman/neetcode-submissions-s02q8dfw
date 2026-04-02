public class Solution {
    public int FindMin(int[] nums) {
        int l = 0;
        int r = nums.Length-1;
        int smallest = Int32.MaxValue;
        //[3,4,5,6,1,2] 
        while(l <r){
            int m = l+ (r-l)/2;
            
            if (nums[r] > nums[m]){
                r = m;
            }else if(nums[r] < nums[m]){
                l = m+1; 
            }
        }
        return nums[r];
    }
}

/*
    if m > R:
    [3,4,5,6,1,2] 
    l    m     r 
    make l = m+1;
    -> [6,1,2]
        l m r 
    -> [1,2]
        l r
        m
    -> [1]
        l  
        r
        this is the min
*/      
