public class Solution {
    public bool IsPalindrome(string s) {
        StringBuilder s1 = new StringBuilder();
        foreach (char c in s)
        {
            if (char.IsLetterOrDigit(c))
            {
                s1.Append(char.ToLower(c));
            }
        }
        string s2 = s1.ToString();
        int j = s2.Length-1;
        for(int i=0;i<(s2.Length/2);i++){
            if(s2[i]!=s2[j]){
                return false;
            }
            j-=1;
        }
        return true;
    }
}