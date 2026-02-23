namespace DataStructureAndAlgorithms.SlidingWindow;

public sealed class LongestUniformSubstringProblem
{
    public static int LongestUniformSubstring(string s, int k)
    {
        if (string.IsNullOrEmpty(s))
        {
            return 0;
        }

        int[] freq = new int[26];
        int left = 0;
        int maxFreq = 0;
        int maxLength = 0;

        for (int right = 0; right < s.Length; right++)
        {
            freq[s[right] - 'A']++;

            maxFreq = Math.Max(maxFreq, freq[s[right] - 'A']);

            int windowSize = right - left + 1;

            if (windowSize - maxFreq > k)
            {
                freq[s[left] - 'A']--;
                left++;
            }

            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }
}
