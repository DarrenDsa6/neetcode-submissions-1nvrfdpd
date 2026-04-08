public class Solution {
    public int MaxProfit(int[] prices) {
        int profit = 0;
        int min = prices[0];
        foreach(int i in prices){
            if(i>min){
                profit = Math.Max(profit, i-min);
            }
            else{
                min = Math.Min(min, i);
            }
        }
        return profit;
    }
}
