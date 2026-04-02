    public class Solution
    {
        public bool IsValidSudoku(char[][] board)
        {
            var rows = new HashSet<char>[9];
            rows = rows.Select(x => new HashSet<char>()).ToArray();
            var cols = new HashSet<char>[9];
            cols = cols.Select(x => new HashSet<char>()).ToArray();
            HashSet<char>[][] boxes = new HashSet<char>[3][];
            for (int i = 0; i < 3; i++)
            {
                boxes[i] = new HashSet<char>[3];
                boxes[i] = boxes[i].Select(x => new HashSet<char>()).ToArray();
            }

            for(int i=0;i<9;i++)
            {
                for(int j=0;j<9;j++)
                {
                    char element = board[i][j];
                    if(element=='.') continue;
                    if (rows[i].Contains(element) || cols[j].Contains(element) || boxes[i /3][j/3].Contains(element))
                    {
                        return false;
                    }
                    else
                    {
                        rows[i].Add(element);
                        cols[j].Add(element);
                        boxes[i / 3][j / 3].Add(element);
                    }
                }
            }
            return true;
        }
    }