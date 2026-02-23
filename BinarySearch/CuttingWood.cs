namespace DataStructureAndAlgorithms.BinarySearch;

public sealed class CuttingWood
{
    static int GetWood(int[] heights, int cutHeight)
    {
        int sum = 0;
        foreach (var h in heights)
        {
            if (h > cutHeight)
            {
                sum += h - cutHeight;
            }
        }
        return sum;
    }

    public static int MaxHeight(int[] heights, int required)
    {
        int low = 0;
        int high = heights.Max();
        int ans = 0;

        while (low <= high)
        {
            int mid = (low + high) / 2;
            if (GetWood(heights, mid) >= required)
            {
                ans = mid;
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }
        return ans;
    }
}
