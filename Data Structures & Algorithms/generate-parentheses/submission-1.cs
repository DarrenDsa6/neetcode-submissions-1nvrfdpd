public class Solution
{
    public List<string> GenerateParenthesis(int n)
    {
        List<string> result = new List<string>();
        GenerateParenthesisHelper("", 0, 0, n, result);
        return result;
    }
    private void GenerateParenthesisHelper(string current, int open, int close, int max, IList<string> result)
    {
        if (current.Length == max * 2)
        {
            result.Add(current);
            return;
        }
        if (open < max)
        {
            GenerateParenthesisHelper(current + "(", open + 1, close, max, result);
        }
        if (close < open)
        {
            GenerateParenthesisHelper(current + ")", open, close + 1, max, result);
        }
    }
}
