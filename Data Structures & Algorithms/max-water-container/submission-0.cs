public class Solution {
    public int MaxArea(int[] heights) {
        int res = 0, area = 0, left = 0, right = heights.Length-1;
        
        while (left < right){
            area = (Math.Min(heights[left], heights[right])) * (right - left);
            res = Math.Max(area, res);
            
            if (heights[left] < heights[right]){
                left++;
            } else{
                right--;
            }
        }
        return res;
    }
}
