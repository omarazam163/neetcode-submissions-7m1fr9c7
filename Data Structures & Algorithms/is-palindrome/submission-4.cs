public class Solution {
            public bool IsPalindrome(string s)
        {
            s=string.Join("",s.Where((x)=>char.IsNumber(x)||char.IsLetter(x))).ToLower();
            int forward = 0;
            int backward = s.Length-1;
            for (int i = 0;i<s.Length;i++)
            {
                if(forward>=backward)
                {
                    break;
                }
                else
                {
                    if (s[forward] != s[backward])
                    {
                        return false;
                    }
                    forward+=1;
                    backward-=1;
                }
            }
            return true;
        }
}

