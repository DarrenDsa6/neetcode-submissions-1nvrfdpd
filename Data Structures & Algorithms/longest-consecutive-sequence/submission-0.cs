public class Solution {
    public int LongestConsecutive(int[] nums) {
        Array.Sort(nums);
        int max = 0;
        int count = 1;
        if(nums.Length == 0){
            return 0;
        }
        for(int i=1;i<nums.Length;i++){
            if(nums[i]==nums[i-1]){
                continue;
            }
            else if(nums[i]-nums[i-1]==1){
                count +=1;
            }
            else{
                max = Math.Max(count, max);
                count = 1;
            }
        }
        max=Math.Max(count,max);
        return max;
    }
}