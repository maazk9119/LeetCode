namespace MySolutions._122.BestTimeToBuyAndSellStoackII
{
    internal class BuyAndSellStock
    {
        public int MaxProfit(int[] prices)
        {
            int totalProfit = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                int buy = prices[i - 1];
                int profit = prices[i] - buy;

                if (profit > 0)
                {
                    totalProfit += profit;
                }
            }

            return totalProfit;
        }
    }
}
