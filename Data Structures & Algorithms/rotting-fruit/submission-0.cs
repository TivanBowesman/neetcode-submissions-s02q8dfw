public class Solution {
    public int OrangesRotting(int[][] grid) {
        int m = grid.Length; 
        int n = grid[0].Length; 

        int minutes = 0;
        int fresh = 0;
        var queue = new Queue<(int, int)>();

        //check for fresh oranges and rotten positions
        for (int i = 0; i < m; i++){
            for (int j = 0; j < n; j++){
                if(grid[i][j] == 1){
                    fresh++;
                }else if(grid[i][j] == 2){
                    queue.Enqueue((i,j));
                }
            }
        }
        if (fresh == 0) return minutes; 

        //bfs
        //directions 
        int[][] directions = { 
            new int[] { 0, 1 }, // right
            new int[] { 0, -1 }, //left
            new int[] { 1, 0 }, // down 
            new int[] { -1, 0 } // up
        };
        
        while(queue.Any()){
            int size = queue.Count;
            for (int i = 0; i < size; i++){
                var (x,y) = queue.Dequeue();
                
                foreach(int[] dir in directions){
                    int row = x + dir[0];
                    int col = y + dir[1];
                    
                    //ensure element is in bounds and fresh
                    if (row >= 0 && row < m && col >= 0 && col < n && grid[row][col] == 1){
                        //change to rotten
                        grid[row][col] = 2;
                        //decrease the amount of fresh fruit remaining
                        fresh--;
                        //add rotten co-ordiantes to queue
                        queue.Enqueue((row,col));
                        
                    }
                }
            }
            

            minutes++;
        }

        //if there is still fresh fruits
        return fresh >= 1 ? -1: minutes - 1;
    }
}
