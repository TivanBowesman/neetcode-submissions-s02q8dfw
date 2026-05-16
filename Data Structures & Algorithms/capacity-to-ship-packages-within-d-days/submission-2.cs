public class Solution {
    public int ShipWithinDays(int[] weights, int days) {
    int min = weights.Max();
    int max = weights.Sum();

    while (min <= max) {
        int mid = min + (max - min) / 2;
        int currSum = 0;
        int daysLeft = days;

        foreach (var w in weights) {
            if (w + currSum > mid) {
                daysLeft--;
                currSum = 0;
            }
            currSum += w;
        }
        daysLeft--;

        if (daysLeft >= 0) max = mid - 1;
        else min = mid + 1;
    }

    return min;
    }
}