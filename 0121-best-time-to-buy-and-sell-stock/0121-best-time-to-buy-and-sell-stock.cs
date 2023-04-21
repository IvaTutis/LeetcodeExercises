public class Solution {
    public int MaxProfit(int[] prices) {
        int minPrice = int.MaxValue; // set initial minimum price to the maximum possible value
        int maxProfit = 0;
        foreach (int price in prices) {
            if (price < minPrice) { // if the current price is lower than the minimum price so far
                minPrice = price; // set the minimum price to the current price
            } else if (price - minPrice > maxProfit) { // if the difference between the current price and the minimum price so far is greater than the maximum profit so far
                maxProfit = price - minPrice; // set the maximum profit to the difference between the current price and the minimum price
            }
        }
        return maxProfit;
    }
}