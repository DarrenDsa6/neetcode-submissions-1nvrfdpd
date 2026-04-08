public class Solution {
    public string MinWindow(string s, string t) {
        Dictionary<char, int> map = new Dictionary<char, int>();

        foreach (char x in t.ToCharArray()) {
            if (map.ContainsKey(x)) {
                map[x]++;
            } else {
                map.Add(x, 1);
            }
        }

        int matched = 0, start = 0, minLen = s.Length + 1, subStr = 0;
        for (int endWindow = 0; endWindow < s.Length; endWindow++) {
            char right = s[endWindow];
            if (map.ContainsKey(right)) {
                map[right]--;
                if (map[right] == 0) matched++;
            }

            while (matched == map.Count) {
                if (minLen > endWindow - start + 1) {
                    minLen = endWindow - start + 1;
                    subStr = start;
                }
                char deleted = s[start++];
                if (map.ContainsKey(deleted)) {
                    if (map[deleted] == 0) matched--;
                    map[deleted]++;
                }
            }
        }
        return minLen > s.Length ? "" : s.Substring(subStr, minLen);
    }
}
