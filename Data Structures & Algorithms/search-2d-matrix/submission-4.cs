public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int n = matrix[0].Length;

        int l = 0;
        int r = (matrix.Length * matrix[0].Length) - 1;


        while(l <= r){
            //1.5 , 1.9
            //[l][r] > target
            //compute l and r
            //
            int mid = l + (r - l) / 2 ;
            Console.WriteLine("mid: " + mid);
            int i = mid / n;
            int j = mid % n;

            int sum = matrix[i][j];
            Console.WriteLine(sum);

            if(sum == target) return true;

            if(sum > target){
                r = mid - 1;
            }else{
                l = mid + 1;
            }
        }

        return false;
    }
}
