namespace akasia_core;

public static class StringUtils
{
    public static int CntWordFromStr(this string str, string word)
    {
        var charStr = new Dictionary<char, int>();

        // Count the frequency of each character in the input string
        foreach (var ch in str)
        {
            if (charStr.ContainsKey(ch))
                charStr[ch]++;
            else
                charStr[ch] = 1;
        }

        var charWord = new Dictionary<char, int>();

        // Count the frequency of each character in the word
        foreach (var ch in word)
        {
            if (charWord.ContainsKey(ch))
                charWord[ch]++;
            else
                charWord[ch] = 1;
        }

        Console.WriteLine(string.Join(",", charWord.Keys));

        var minValue = int.MaxValue;

        // Check if the current word can be constructed from the input string
        foreach (var c in charWord.Keys)
        {
            // The word contains a character not present in the input string
            if (!charStr.ContainsKey(c))
                return 0;

            int charCount = charStr[c] / charWord[c];

            if (charCount < minValue)
                minValue = charCount;

        }
        return minValue;
    }
}
