using System.Text;

namespace MySolutions._451.SortCharactersByFrequency
{
    internal class ShortCharacters
    {
        public string FrequencySort(string s)
        {
            StringBuilder result = new StringBuilder();
            Dictionary<char, int> frequency = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (!frequency.ContainsKey(s[i]))
                {
                    frequency.Add(s[i], 1);
                    continue;
                }

                frequency[s[i]] += 1;
            }

            foreach (KeyValuePair<char, int> fre in frequency.OrderByDescending(x => x.Value))
            {
                result.Append(fre.Key, fre.Value);
            }

            return result.ToString();
        }
    }
}
