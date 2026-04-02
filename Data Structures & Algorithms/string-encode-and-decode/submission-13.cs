    public class Solution
    {
                public string Encode(IList<string> strs)
        {
            StringBuilder sb = new();
            foreach (string s in strs)
            {
                sb.Append(s.Length);
                sb.Append('#');
                sb.Append(s);
            }
            return sb.ToString();
        }

        public List<string> Decode(string s)
        {
            List<string> res = new();
            for(int i =0;i<s.Length;i++)
            {
                int j = i;
                while (s[j]!='#')
                {
                    j++;
                }
                StringBuilder sb = new();
                for(int m=i;m<j;m++)
                {
                   sb.Append(s[m]);
                }
                int length = int.Parse(sb.ToString());
                res.Add(s.Substring(j+1, length));
                i=j+length;
            }
            return res;
        }
    }
