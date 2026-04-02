    public class Solution
    {
        bool check(StringBuilder sp)
        {
            int l = 0;
            int r = sp.Length - 1;
            while (r > l)
            {
                if (sp[r] != sp[l]) return false;
                l++;
                r--;
            }
            return true;
        }
        List<List<string>> final = new();
        List<string> curr = new();
        string s;
        void solve(int i, StringBuilder sp)
        {
            if(i>=s.Length)
            {
                if(sp.Length==0)
                {
                    final.Add(new List<string>(curr));
                }
                return;
            }

            sp.Append(s[i]);
            //take
            if(check(sp))
            {
                curr.Add(sp.ToString());
                solve(i + 1,new StringBuilder());
                curr.RemoveAt(curr.Count - 1);
            }
            solve(i + 1, sp);
        }
        public List<List<string>> Partition(string s)
        {
            this.s = s;
            solve(0, new StringBuilder());
            return final;
        }
    }
