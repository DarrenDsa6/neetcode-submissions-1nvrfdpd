public class Solution {
    public bool IsValid(string s) {
        Stack<char> brackets = new Stack<char>();
        foreach(char c in s){
            if(c == '(' || c=='{' || c=='['){
                brackets.Push(c);
            }
            else{
                if(brackets.Count>0){
                    char topele = brackets.Peek();
                    if(topele=='{' && c=='}'){
                        brackets.Pop();
                    }
                    else if(topele=='[' && c==']'){
                        brackets.Pop();
                    }
                    else if(topele=='(' && c==')'){
                        brackets.Pop();
                    }
                    else{
                        return false;
                    }
                }
                else{
                    return false;
                }
            }
        }
        if (brackets.Count == 0){
            return true;
        }
        return false;
    }
}