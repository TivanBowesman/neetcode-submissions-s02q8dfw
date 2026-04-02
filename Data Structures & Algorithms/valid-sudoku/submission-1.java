class Solution {
    public boolean isValidSudoku(char[][] board) {
        int m = board.length;
        int n = board[0].length;
 
        //validate rows
        for(int i = 0; i < m; i++){
            Set<Character> hashset = new HashSet<>();
            for(int j = 0; j < n; j++){
                if(hashset.contains(board[i][j])){
                    return false;
                }else if(board[i][j] == '.'){
                    continue;
                }
                hashset.add(board[i][j]);
            }
        }
        //validate cols
        for(int i = 0; i < m; i++){
            Set<Character> hashset = new HashSet<>();
            for(int j = 0; j < n; j++){
                if(hashset.contains(board[j][i])){
                    return false;
                }else if(board[j][i] == '.'){
                    continue;
                }
                hashset.add(board[j][i]);
            }
        }

        //validate grids
        for (int square = 0; square < 9; square++) {
            Set<Character> seen = new HashSet<>();
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                    int row = (square / 3) * 3 + i;
                    int col = (square % 3) * 3 + j;
                    if (board[row][col] == '.') continue;
                    if (seen.contains(board[row][col])) return false;
                    seen.add(board[row][col]);
                }
            }
        }

        return true;


    }
}
