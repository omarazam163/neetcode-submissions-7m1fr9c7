    public class Solution
    {

        public string Encode(IList<string> strs)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < strs.Count; i++)
            {
                result.Append($"{strs[i].Length};");
                result.Append(strs[i]);
            }
            return result.ToString();
        }

        public List<string> Decode(string s)
        {
            List<string> res = new List<string>();
            int index = 0;
            while(index < s.Length)
            {
                int startIndex = index;
                while (s[index]!=';')
                {
                    index++;
                }
                int number = int.Parse(s[startIndex..index]);
                string srt = s[(index + 1)..(index + 1 + number)];
                res.Add(srt);
                index = index + 1 + number;
            }
            return res;
        }
    }