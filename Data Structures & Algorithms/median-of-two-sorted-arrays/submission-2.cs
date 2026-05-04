public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int m = nums1.Length;
        int n = nums2.Length;
        if ((m + n ) == 0 ){
            return 0;
        }
        int oddCheck = (m+n) % 2;

        //even

        var list = new List<int>();
        int i = 0 ;
        int j = 0; 
        while (i != m && j != n){
            if(nums1[i] > nums2[j]){
                list.Add(nums2[j]);
                j++;
            }else{
                list.Add(nums1[i]);
                i++;
            }
        }
        //check m or n
        if(i == m){
            while( j != n){
                list.Add(nums2[j]);
                j++;
            }
        }else{
            while(i != m){
                list.Add(nums1[i]);
                i++;
            }
        }
        //sorted array 

        //get mid
        int mid = (m+n) / 2;        

        return oddCheck == 0 ? (list[mid - 1] + list[mid]) / 2.0 : list[mid];
    }
}
