public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int[] ans = new int[temperatures.Length];
        Stack<int> index = new Stack<int>();
        for(int i=0; i<temperatures.Length;i++){
            if(index.Count == 0){
                index.Push(i);
            }   
            else{
                while(index.Count>0 && temperatures[i] > temperatures[index.Peek()]){
                    int del = index.Pop();
                    ans[del] = i - del;
                }
                index.Push(i);
            }         
        }
        foreach(int i in index){
            ans[i] = 0;
        }
        return ans;
    }
}