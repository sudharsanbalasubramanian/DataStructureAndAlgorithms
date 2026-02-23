namespace DataStructureAndAlgorithms.SlidingWindow;

public static class LongestSubstringWithUniqueCharacterProblem
{
    public static int LongestSubstringWithUniqueCharacter(string str)
    {
        if (string.IsNullOrEmpty(str))
        {
            return 0;
        }

        var dict = new Dictionary<char, int>();
        int left = 0;
        int maxLength = 0;

        for (int right = 0; right < str.Length; right++)
        {
            char currentChar = str[right];

            // If character exists and is inside current window
            if (dict.TryGetValue(currentChar, out int value) && value >= left)
            {
                left = value + 1;
            }

            dict[currentChar] = right;

            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }
}
