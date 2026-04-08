public class Solution {
    public int CharacterReplacement(string s, int k) {
        int left = 0, maxLength = 0;
        int mostFrequentLetterCount = 0; 
        int[] charCounts = new int[26]; 

        for (int right = 0; right < s.Length; right++) {
            charCounts[s[right] - 'A']++;
            mostFrequentLetterCount = Math.Max(mostFrequentLetterCount, charCounts[s[right] - 'A']);

            int lettersToChange = (right - left + 1) - mostFrequentLetterCount;
            if (lettersToChange > k) { 
                charCounts[s[left] - 'A']--;
                left++;
            }

            maxLength = Math.Max(maxLength, (right - left + 1));
        }
        return maxLength;
    }
}
