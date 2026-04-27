public class Solution {

    public bool Exist(char[][] board, string word) {
        //search recursively 
        //if whole word found return true
        int m = board.Length;
        int n = board[0].Length;

        //find start of word
        for(int i = 0; i < m; i++){
            var ans = false;
            for(int j = 0; j < n; j++){
                var currChar = board[i][j];
                if (currChar == word[0]){
                    // recursive check
                    ans = helper(board, word, i, j, 0);

                }
                
                if (ans) return true;
                
            }
        }

        return false;
    }

    //recursive function
    public bool helper(char[][] board, string word, int i, int j, int currIndex){
        int m = board.Length;
        int n = board[0].Length;

        if (currIndex == word.Length) return true;
        

        //check for correct boundarys
        if( i < 0 || i >= m || j < 0 || j >= n || word[currIndex] != board[i][j]){
            return false;
        }

        char temp = board[i][j];
        board[i][j] = '#';
        
        //return if letter is not the next letter in word
        
        //up
        bool res = helper(board, word, i - 1, j, currIndex + 1)||
        //down
        helper(board, word, i + 1, j, currIndex + 1)||
        //left
        helper(board, word, i, j - 1, currIndex + 1)||
        //right
        helper(board, word, i, j + 1, currIndex + 1);

        board[i][j] = temp;

        return res;


    }
}
