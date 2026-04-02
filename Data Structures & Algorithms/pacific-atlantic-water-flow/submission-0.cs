public class Solution {
    public List<List<int>> PacificAtlantic(int[][] heights) {
        int m = heights.Length;
        int n = heights[0].Length;

        var pacific = new HashSet<(int, int)>();
        var atlantic = new HashSet<(int, int)>();

        var queueP = new Queue<(int, int)>();
        var queueA = new Queue<(int, int)>();

        // Pacific borders
        for (int i = 0; i < n; i++) {
            queueP.Enqueue((0, i));
            pacific.Add((0, i));
        }
        for (int i = 1; i < m; i++) {
            queueP.Enqueue((i, 0));
            pacific.Add((i, 0));
        }

        // Atlantic borders
        for (int i = 0; i < n; i++) {
            queueA.Enqueue((m - 1, i));
            atlantic.Add((m - 1, i));
        }
        for (int i = 0; i < m - 1; i++) {
            queueA.Enqueue((i, n - 1));
            atlantic.Add((i, n - 1));
        }

        BFS(queueP, pacific, heights, m, n);
        BFS(queueA, atlantic, heights, m, n);

        var result = new List<List<int>>();
        foreach (var cell in pacific) {
            if (atlantic.Contains(cell)) {
                //tuple so item1 and 2
                result.Add(new List<int> { cell.Item1, cell.Item2 });
            }
        }

        return result;
    }

    private void BFS(Queue<(int, int)> queue, HashSet<(int, int)> visited, int[][] heights, int m, int n) {
        int[][] dirs = { new[] {1,0}, new[] {-1,0}, new[] {0,1}, new[] {0,-1} };

        while (queue.Any()) {
            var (r, c) = queue.Dequeue();

            foreach (var d in dirs) {
                int nr = r + d[0];
                int nc = c + d[1];

                if (nr >= 0 && nr < m && nc >= 0 && nc < n &&
                    !visited.Contains((nr, nc)) &&
                    heights[nr][nc] >= heights[r][c]) 
                {
                    visited.Add((nr, nc));
                    queue.Enqueue((nr, nc));
                }
            }
        }
    }
}


