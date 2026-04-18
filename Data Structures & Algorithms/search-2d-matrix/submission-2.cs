public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        var rowLength = matrix.Length;
        var columnLength = matrix[0].Length;

        // search for right row 
        var l = 0;
        var r = rowLength * columnLength - 1;

        while (r >= l)
        {
            var m = (l + r) / 2;
            var midVal = matrix[m / columnLength][m % columnLength];
            if (midVal == target)
                return true;
            else if (midVal > target)
            {
                r = m - 1;
            }
            else
            {
                l = m + 1;
            }
        }

        return false;
    }
}
