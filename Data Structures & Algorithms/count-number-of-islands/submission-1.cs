public class Solution {
    public int NumIslands(char[][] grid) {
        //get num islands
        int num = 0;

        //get ones
        int m = grid.Length;
        int n = grid[0].Length; 

        for (int i = 0; i < m ; i++){
            for(int j = 0; j < n ; j++){
                if (grid[i][j] == '1'){
                    num++;
                    dfs(i,j,m,n,grid);
                }
            }
        }

        return num;
    }

    public void dfs(int i, int j, int m, int n, char[][] grid ){
        //esnure its in a valid pos 
        if (i < 0 || i >= m || j < 0|| j >= n || grid[i][j] != '1'){
            return;
        }

        //turn 1 -> 0
        grid[i][j] = '0';

        dfs(i+1, j, m, n , grid);//down
        dfs(i-1, j, m, n , grid);//up
        dfs(i, j+1, m, n , grid);//right
        dfs(i, j-1, m, n , grid);//left
    }
}
