    public class Solution
    {
        HashSet<string> visited;
        int cols;
        int rows;
        char[][] grid;
        public void bfs(int x,int y)
        {
            Queue<Tuple<int, int>> que = new();
            visited.Add($"{x},{y}");
            que.Enqueue(new Tuple<int, int>(x,y));
            int[][] directions = new int[][]
{
    new int[] { 1, 0 },
    new int[] { -1, 0 },
    new int[] { 0, 1 },
    new int[] { 0, -1 }
};
            while(que.Count>0)
            {
                Tuple<int, int> curr = que.Dequeue();
                foreach(var dir in directions)
                {
                    int r = dir[0] +curr.Item1; int c = dir[1]+ curr.Item2;
                    if ( r <rows && r >=0 && c>=0 && c<cols && grid[r][c]=='1' && !visited.Contains($"{r},{c}"))
                    {
                        que.Enqueue(new Tuple<int,int>(r,c));
                        visited.Add($"{r},{c}");
                    }
                }
            }
        }
        public int NumIslands(char[][] grid)
        {
            if (grid == null) return 0;
            this.grid = grid;
            int numberOfIslands = 0;
            int rows = grid.Length; int cols = grid[0].Length;
            this.rows = rows; this.cols = cols;
            this.visited = new();
            for(int i=0;i<rows;i++)
            {
                for(int j=0;j<cols;j++)
                {
                    if (grid[i][j]=='1' && !visited.Contains($"{i},{j}"))
                    {
                        bfs(i, j);
                        numberOfIslands++;
                    }
                }
            }
            return numberOfIslands;
        }
    }