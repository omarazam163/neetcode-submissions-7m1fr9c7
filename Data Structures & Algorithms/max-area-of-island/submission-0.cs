    public class Solution
    {
        int rows;
        int col;
        HashSet<string> visited = new();
        int[][] grid;

        int bfs(int i,int j)
        {
            Queue<Tuple<int, int>> que = new();
            que.Enqueue(new Tuple<int,int>(i, j));
            visited.Add($"{i},{j}");
            int space = 1;
            int[][] directions = new int[][]
{
    new int[] { 1, 0 },
    new int[] { -1, 0 },
    new int[] { 0, 1 },
    new int[] { 0, -1 }
};
            while (que.Count > 0)
            {
                Tuple<int, int> curr = que.Dequeue();
                foreach (var dir in directions)
                {
                    int r = dir[0] + curr.Item1; int c = dir[1] + curr.Item2;
                    if (r < rows && r >= 0 && c >= 0 && c < col && grid[r][c] == 1 && !visited.Contains($"{r},{c}"))
                    {
                        que.Enqueue(new Tuple<int, int>(r, c));
                        space++;
                        visited.Add($"{r},{c}");
                    }
                }
            }
            return space;
        }
        public int MaxAreaOfIsland(int[][] grid)
        {
            int rows = grid.Length;
            int col = grid[0].Length;
            this.rows = rows;
            this.col = col;
            this.grid = grid;
            int res = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (grid[i][j] == 1 && !visited.Contains($"{i},{j}"))
                    {
                        res = Math.Max(res, bfs(i, j));
                    }
                }
            }
            return res;
        }
    }