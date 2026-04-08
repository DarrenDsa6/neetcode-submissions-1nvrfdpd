public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> ans = new Dictionary<string,List<string>>();
        foreach( string str in strs){
            int[] count = new int[26];
            foreach(char c in str){
                count[c - 'a']++;
            }
            string key = string.Join(',',count);
            if(ans.ContainsKey(key)){
                ans[key].Add(str);
            }
            else{
                ans[key] = new List<string>();
                ans[key].Add(str);
            }
        }
        return new List<List<string>>(ans.Values);
    }
}