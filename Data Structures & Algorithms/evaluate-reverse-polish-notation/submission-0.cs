public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> nums = new Stack<int>();

        foreach(string token in tokens){
            if (int.TryParse(token, out int number)) {
                nums.Push(number);
            } else {
                int num2 = nums.Pop();
                int num1 = nums.Pop();
                
                switch (token) {
                    case "+":
                        nums.Push(num1 + num2);
                        break;
                    case "-":
                        nums.Push(num1 - num2);
                        break;
                    case "*":
                        nums.Push(num1 * num2);
                        break;
                    case "/":
                        // Implement integer division that truncates towards zero
                        nums.Push(num1 / num2);
                        break;
                }
            }
        }
        return nums.Pop();
    }
}
