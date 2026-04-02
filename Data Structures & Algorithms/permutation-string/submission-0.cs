public class Solution {
                static bool compareDic(Dictionary<char, int> dic1, Dictionary<char, int> dic2 )
            {
                if (dic1.Values.Count != dic2.Values.Count) return false;
                foreach(char x in dic1.Keys)
                {
                    if (dic2.ContainsKey(x))
                    {
                        if (dic2[x] != dic1[x]) return false;
                    }
                    else
                    {
                        return false;
                    }
                }
                return true;
            }

            public bool CheckInclusion(string s1, string s2)
            {
                Dictionary<char, int> dic = new();
                foreach (char x in s1)
                {
                    if (dic.ContainsKey(x)) dic[x] += 1;
                    else dic[x] = 1;
                }
                int l = 0;
                Dictionary<char, int> currentDic = new();
                for (int r = 0; r < s2.Length; r++)
                {
                    if (currentDic.ContainsKey(s2[r])) currentDic[s2[r]] += 1;
                    else currentDic[s2[r]] = 1;
                    int w = (r-l) + 1;
                    while(w>s1.Length)
                    {
                        currentDic[s2[l]]--;
                        if (currentDic[s2[l]] == 0) currentDic.Remove(s2[l]);
                        l++;
                        w = (r-l) + 1;
                    }
                    if (compareDic(dic, currentDic)) return true;
                }
                return false;
            }
}
