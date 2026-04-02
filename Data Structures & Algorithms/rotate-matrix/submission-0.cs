public class Solution {
    public void Rotate(int[][] matrix) {
        //flip the image horizontally corner to corner
        //flip the image horizontally from th middle

        //flip i and j
        for(int i =  0; i < matrix.Length; i++){
            for(int j = i+1; j < matrix[0].Length; j++){
                var temp = matrix[i][j];

                matrix[i][j] = matrix[j][i];
                matrix[j][i] = temp;
            }
        }

        //mirror  the matrix
        //take the end and swap with the front
        //move in until matrix.length / 2

        for (int i = 0; i < matrix[0].Length; i++) {
            for (int j = 0; j < matrix[0].Length / 2; j++) {
                int temp = matrix[i][j];
                matrix[i][j] = matrix[i][matrix[0].Length - 1 - j];
                matrix[i][matrix[0].Length - 1 - j] = temp;
            }
        }
        
    }
}
