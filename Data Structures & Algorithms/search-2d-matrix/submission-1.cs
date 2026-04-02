public class Solution {
        public bool SearchMatrix(int[][] matrix, int target)
        {

            int height = matrix.Length;
            int width = matrix[0].Length;
            int l_index = 0;
            int r_index = width*height-1;
            while (r_index>=l_index)
            {
                int m_index = (l_index + r_index) / 2;
                int[]m = new int[2] {m_index%width,m_index/width};
                if (matrix[m[1]][m[0]] == target) return true;
                else if (matrix[m[1]][m[0]] > target) r_index = m_index - 1;
                else l_index= m_index+1;
            }
            return false;
        }
}
  