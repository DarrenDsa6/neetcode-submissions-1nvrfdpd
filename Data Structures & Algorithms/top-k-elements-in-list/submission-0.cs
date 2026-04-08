public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var Dict = new Dictionary<int, int>();
        foreach(int num in nums){
            if (Dict.ContainsKey(num)){
                Dict[num]++;
            }
            else{
                Dict[num] = 1;
            }
        }
        var topK = Dict.OrderByDescending(pair => pair.Value)
                                .Take(k)
                                .Select(pair => pair.Key)
                                .ToArray();
        return topK;
    }
}
