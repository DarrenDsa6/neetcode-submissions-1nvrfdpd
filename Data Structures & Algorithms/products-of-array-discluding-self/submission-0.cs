public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] ans = new int[nums.Length];
        Array.Fill(ans, 1);
        for(int i = 0; i<nums.Length;i++){
            for(int j=0;j<nums.Length;j++){
                if (i!=j){
                    ans[j] *= nums[i];
                }
            }
        }
        return ans;
    }
}
