public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int cols = matrix[0].Length;
        for(int i=0;i<matrix.Length;i++){
            if(target<=matrix[i][cols-1]){
                for(int j=0; j<cols;j++){
                    if(matrix[i][j]==target){
                        return true;
                    }
                }
            }
        }
        return false;
    }
}
