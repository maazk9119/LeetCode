namespace MySolutions._520.DetectCapital
{
    internal class DetectCaptialClass
    {
        public static bool Solution(string word)
        {
            if (word.ToUpper() == word || word.ToLower() == word)
            {
                return true;
            }

            if (Char.IsUpper(word[0]))
            {
                for (int i = 1; i < word.Length; i++)
                {
                    if (Char.IsUpper(word[i]))
                    {
                        return false;
                    }
                }

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
