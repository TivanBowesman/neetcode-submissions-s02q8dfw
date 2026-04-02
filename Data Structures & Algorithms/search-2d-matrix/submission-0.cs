public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        //matrix[i][j]
        //3 rows
        int rows = matrix.Length;
        //4 columns  
        int columns = matrix[0].Length;
        //i = m / n 
        //j = m % n
        int l = 0;
        int r = (columns * rows) - 1;

        while (l <= r){
            int mid = l +((r-l)/2);
            int i = mid / columns;
            int j = mid % columns;

            if (matrix[i][j] == target){
                return true;
            }else if (matrix[i][j] > target){
                r = mid - 1;
            }else{
                l = mid + 1;
            }
        } 
        return false;
    }
}

/*
    non-decreasing = can have duplicates 
    binary search
*/
