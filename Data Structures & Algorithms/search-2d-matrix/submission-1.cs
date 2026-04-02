public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        //i is (/columns)
        //j is (%columns)

        int rows = matrix.Length;
        int columns = matrix[0].Length;

        // list is in order so binary search 

        int l = 0;
        int r = (rows*columns)-1;
        
        while(l <= r){
            int mid = l + (r-l)/2;
            int i = mid / columns;
            int j = mid % columns;

            int num = matrix[i][j];

            if (num == target){
                return true;
            }else if (num > target){
                r = mid - 1;
            }else {
                l = mid + 1;
            }
        }
        return false;
    }
}
