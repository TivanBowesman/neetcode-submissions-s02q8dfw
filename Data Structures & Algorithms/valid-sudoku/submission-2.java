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
        int[][] starts = new int[][]{
            {0,0}, {0,3}, {0,6},
            {3,0}, {3,3}, {3,6},
            {6,0}, {6,3}, {6,6}
        };

        //validate grids
        for(int[] start : starts){
            Set<Character> seen = new HashSet<>();
            for(int i = start[0]; i < start[0] + 3; i++){
                for (int j = start[1]; j < start[1] + 3; j++){
                    if (board[i][j] == '.') continue;
                    if (seen.contains(board[i][j])) return false;
                    seen.add(board[i][j]);
                }
            }
        } 
   

        return true;


    }
}
