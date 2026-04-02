public class Solution {
    public int NumIslands(char[][] grid) {
        //perform dfs (down and across)
        //mark as zero to show the island has been visited
        int NumOfIslands = 0; 
        //get lengths
        int m = grid.Length; 
        int n = grid[0].Length;
        for(int i = 0; i < m; i++){
            for(int j = 0; j < n;  j++){
                if (grid[i][j] == '1'){
                    NumOfIslands++;
                    dfs(i, j, m, n, grid);
                }
            }
        }

        return NumOfIslands;


    }

    //function traverses and conversts 0 -> 1
    public void dfs(int i, int j, int m, int n, char[][] grid){
        //if i or j is less than zero it means its out of bounds
        if (i < 0 || i >= m || j < 0 || j >= n || grid[i][j] != '1'){
            return;
        }

        //if we get here the postion is valid and is a 1
        grid[i][j] = '0';
        //perform dfs on right,down,left up
        dfs(i, j+1, m,n, grid); //right
        dfs(i+1, j, m,n, grid); //down 
        dfs(i-1, j, m,n, grid); //up 
        dfs(i, j - 1, m,n, grid); //left
    }
}
