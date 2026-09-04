public class Solution {
    public int MaxProfit(int[] prices) {
        int n = prices.Length;

    int[] dp = new int[n];
    
    dp[0] = 0;

    int minPrice = prices[0];

    for (int i = 1; i < n; i++)
    {
        minPrice = Math.Min(minPrice, prices[i]);

        int dontSell = dp[i - 1];

        int sellToday = prices[i] - minPrice;

        dp[i] = Math.Max(dontSell, sellToday);
    }

    return dp[n - 1];
    }
}
