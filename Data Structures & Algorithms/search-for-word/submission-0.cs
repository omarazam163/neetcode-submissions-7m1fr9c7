    public class Solution
    {
        string target;
        char[][] board;
        bool res = false;

        bool solve(int r, int c, int rows, int cols, int i)
        {
            if (i == target.Length) return true;
            if (r < 0 || c < 0 || r >= rows || c >= cols || board[r][c]=='#'||board[r][c] != target[i] ) return false;
            board[r][c] = '#';
            bool res = solve(r + 1, c, rows, cols, i + 1) ||
                       solve(r - 1, c, rows, cols, i + 1) ||
                       solve(r, c + 1, rows, cols, i + 1) ||
                       solve(r, c - 1, rows, cols, i + 1);
            board[r][c] = target[i];
            return res;
        }
        public bool Exist(char[][] board, string word)
        {
            int rows = board.Length;
            int col = board[0].Length;
            this.board = board;
            this.target = word;
            for(int i=0;i<rows;i++)
            {
                for(int j=0;j<col;j++)
                {
                    if (solve(i, j, rows, col, 0)) return true;
                }
            }
            return false;
        }
    }