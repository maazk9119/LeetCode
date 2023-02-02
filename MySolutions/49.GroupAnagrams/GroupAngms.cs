namespace MySolutions._49.GroupAnagrams
{
    internal class GroupAngms
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, List<string>> save = new Dictionary<string, List<string>>();
            IList<IList<string>> result = new List<IList<string>>();


            for (int i = 0; i < strs.Length; i++)
            {
                char[] str = strs[i].ToArray();
                Array.Sort(str);
                string sortedStr = string.Join("", str);

                if (!save.ContainsKey(sortedStr))
                {
                    save[sortedStr] = new List<string>()
                    {
                    strs[i]
                    };
                }
                else
                {
                    save[sortedStr].Add(strs[i]);
                }
            }


            foreach (var i in save)
            {
                result.Add(i.Value.ToList());
            }

            return result;
        }
    }
}
