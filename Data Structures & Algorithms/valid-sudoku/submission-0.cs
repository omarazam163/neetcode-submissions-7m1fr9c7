public class Solution {
            public bool IsValidSudoku(char[][] board)
            {
                Dictionary<int, HashSet<int>> rows = Enumerable.Range(0, 10).ToDictionary(i => i, i => new HashSet<int>());
                Dictionary<int, HashSet<int>> cols = Enumerable.Range(0, 10).ToDictionary(i => i, i => new HashSet<int>());
                Dictionary<Tuple<int, int>, HashSet<int>> blocks = new();
                for(int i=0;i<3;i++)
                {
                    for(int j=0;j<3;j++)
                    {
                        blocks.Add(new Tuple<int, int>(i, j), new HashSet<int>());
                    }
                }
                for (int i = 0; i < board.Length; i++)
                {
                    for (int j = 0; j < board[i].Length; j++)
                    {
                        if (board[i][j] == '.') continue;
                        if (rows[i].Contains(board[i][j]) || cols[j].Contains(board[i][j]) || blocks[new Tuple<int, int>(i / 3, j / 3)].Contains(board[i][j]))
                        {
                            return false;
                        }
                        rows[i].Add(board[i][j]);
                        cols[j].Add(board[i][j]);
                        blocks[new Tuple<int, int>(i / 3, j / 3)].Add(board[i][j]);
                    }
                }
                return true;
            }
}
