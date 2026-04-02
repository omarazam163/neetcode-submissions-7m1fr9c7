public class Solution {

    public string Encode(IList<string> strs) {
        var builder = new StringBuilder();
        foreach(var str in strs)
        {
            builder.Append($"{str.Length};");
            builder.Append(str);
        }
        return builder.ToString();
    }

        public List<string> Decode(string s)
        {
            int index = 0;
            var res = new List<string>();
            for (int i=1;i < s.Length;i++)
            {
                if (s[i] == ';' && char.IsNumber(s[i-1]))
                {
                    var length = int.Parse(s.Substring(index, i - index));
                    index = i + length + 1;
                    res.Add(s.Substring(i + 1, length));
                }
            }
            return res;
        }
}
