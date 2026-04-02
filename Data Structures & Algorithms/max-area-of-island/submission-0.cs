public class Solution {
    public int MaxAreaOfIsland(int[][] grid) {
        int max = 0;
        int m = grid.Length; 
        int n = grid[0].Length;

        for(int i = 0; i < m; i++){
            for(int j = 0; j < n; j++){
                if(grid[i][j] == 1){
                    max = Math.Max(max , Dfs(i, j, m, n, grid));
                }
            }
        }

        return max;
    }

    public int Dfs(int i, int j, int m, int n, int[][] grid){
        if (i < 0 || i >= m || j < 0 || j >= n || grid[i][j] != 1){
            return 0 ;
        }
 
        //mark as seen
        grid[i][j] = 0; 

        
        int area = 1;

        area += Dfs(i - 1, j, m, n, grid); // up
        area += Dfs(i + 1, j, m, n, grid); // down
        area += Dfs(i, j - 1, m, n, grid); // left
        area += Dfs(i, j + 1, m, n, grid); // right

        return area;
    }
    
}
