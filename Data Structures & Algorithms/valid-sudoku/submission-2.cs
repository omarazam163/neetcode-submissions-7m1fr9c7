public class Solution {
        public bool IsValidSudoku(char[][] board)
        {
            var rows = Enumerable.Range(0, 9).ToDictionary(x => x, x => new HashSet<char>());
            var cols = Enumerable.Range(0, 9).ToDictionary(x => x, x => new HashSet<char>());
            var boxes = Enumerable.Range(0, 3).SelectMany(x => Enumerable.Range(0, 3).Select(y => $"{x},{y}")).
                ToDictionary(x => x, x => new HashSet<char>());

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    var c = board[i][j];
                    if (c == '.')
                        continue;
                    if (!(rows[i].Add(c) && cols[j].Add(c) && boxes[$"{i/3},{j/3}"].Add(c)))
                    {
                        return false;
                    }
                }
            }

            return true;
        }
}
