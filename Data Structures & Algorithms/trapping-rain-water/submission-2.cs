public class Solution {
    public int Trap(int[] height) {
        if(height.Length==0){
            return 0;
        }
        int res = 0;
        int l = 0;
        int r = height.Length - 1;
        int lmax = height[l];
        int rmax = height[r];
        while(l<r){
            if(lmax<rmax){
                l+=1;
                lmax = Math.Max(lmax, height[l]);
                res += lmax - height[l];
            }
            else{
                r-=1;
                rmax = Math.Max(rmax, height[r]);
                res += rmax - height[r];
            }
        }
        return res;

    }
}
