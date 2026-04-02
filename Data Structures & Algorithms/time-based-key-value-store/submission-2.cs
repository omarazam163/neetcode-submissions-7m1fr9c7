    public class TimeMap
    {
        Dictionary<string, List<Tuple<int, string>>> dic;
        public TimeMap()
        {
            this.dic= new();
        }

        public void Set(string key, string value, int timestamp)
        {
            if(dic.ContainsKey(key))
            {
                dic[key].Add(new Tuple<int, string>(timestamp,value));
            }
            else
            {
                dic[key] = new();
                dic[key].Add(new Tuple<int, string>(timestamp, value));
            }
        }

        public string Get(string key, int timestamp)
        {
            if (!dic.ContainsKey(key))
            {
                return "";
            }
            List<Tuple<int, string>> values = dic[key];
            int l = 0;
            int r = values.Count;
            while(l<r)
            {
                int m = (l + r) / 2;
                if (values[m].Item1>timestamp)
                {
                    r = m;
                }
                else
                {
                    l = m + 1;
                }
            }
            if(l==0)
            {
                if (timestamp == values[0].Item1) return values[0].Item2;
                else return "";
            }
            else
            {
                return values[l - 1].Item2;
            }
        }
    }