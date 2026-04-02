public class Solution {
    public void SetZeroes(int[][] matrix) {
        int m = matrix.Length; 
        int n = matrix[0].Length; 
        var q = new Queue<(int,int)>();
        //find co-ordinates of 0;
        for(int i = 0; i < m; i++){
            for (int j = 0; j < n; j++){
                if (matrix[i][j] == 0 ){
                    q.Enqueue((i,j));
                }
            }
        }



        while(q.Any()){
            var size = q.Count;

            for(int i = 0; i < size; i++){
                var (x, y ) = q.Dequeue(); 
                
                //change row and col
                for(int row = 0; row < m; row++){
                    matrix[row][y] = 0;
                    for(int col = 0; col < n; col++){
                        matrix[x][col] = 0;  
                    }
                }
            }
        }
    }
}
