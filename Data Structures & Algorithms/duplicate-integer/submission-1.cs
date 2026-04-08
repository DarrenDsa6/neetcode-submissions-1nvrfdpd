public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> elements = new HashSet<int>();
        foreach(int i in nums){
            if (elements.Contains(i)){
                return true;
            }
            else{
                elements.Add(i);
            }
        }
        return false;
    }
}
