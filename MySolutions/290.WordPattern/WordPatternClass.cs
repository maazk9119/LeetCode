namespace MySolutions._290.WordPattern
{
    internal class WordPatternClass
    {
        public bool Solution(string pattern, string s)
        {
            Dictionary<char, string> test = new Dictionary<char, string>();
            string[] str = s.Split(" ");

            if (pattern.Length != str.Length)
            {
                return false;
            }

            bool result = true;

            for (int i = 0; i < pattern.Length; i++)
            {
                if (!test.ContainsKey(pattern[i]))
                {
                    foreach (var kv in test)
                    {
                        if (kv.Value == str[i])
                        {
                            result = false;
                        }
                    }

                    if (!result)
                    {
                        break;
                    }

                    test[pattern[i]] = str[i];
                }
                else
                {
                    if (str[i] != test[pattern[i]])
                    {
                        result = false;
                        break;
                    }
                }
            }

            return result;
        }
    }
}
