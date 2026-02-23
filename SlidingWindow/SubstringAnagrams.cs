using SharedProject.Extensions;

namespace DataStructureAndAlgorithms.SlidingWindow;

public sealed class SubstringAnagrams
{
    public static int CountOfSubstringAnagram(string s, string t)
    {
        if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t) || t.Length > s.Length)
        {
            return 0;
        }

        int count = 0;
        int windowSize = t.Length;
        int[] expected = new int[26];
        int[] window = new int[26];

        // Build frequency of t (expected anagram frequency)
        foreach (var c in t)
        {
            expected[c - 'a']++;
        }

        // Build initial window
        for (int i = 0; i < windowSize; i++)
        {
            window[s[i] - 'a']++;
        }

        // Check first window
        if (expected.AreArraysEqual(window))
        {
            count++;
        }

        // Slide window
        for (int i = windowSize; i < s.Length; i++)
        {
            window[s[i] - 'a']++; // add new char
            window[s[i - windowSize] - 'a']--; // remove old char

            if (expected.AreArraysEqual(window))
            {
                count++;
            }
        }

        return count;
    }
}
