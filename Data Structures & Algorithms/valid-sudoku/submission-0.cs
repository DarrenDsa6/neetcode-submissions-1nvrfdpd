public class Solution {
    public bool IsValidSudoku(char[][] board) {
        Dictionary<int, HashSet<char>> cols = new Dictionary<int, HashSet<char>>();
        Dictionary<int, HashSet<char>> rows = new Dictionary<int, HashSet<char>>();
        Dictionary<int, HashSet<char>> squares = new Dictionary<int, HashSet<char>>();

        for (int r = 0; r < 9; r++) {
            for (int c = 0; c < 9; c++) {
                char cell = board[r][c];
                if (cell == '.') continue;

                int squareIndex = (r / 3) * 3 + c / 3;

                if (!rows.ContainsKey(r)) rows[r] = new HashSet<char>();
                if (!cols.ContainsKey(c)) cols[c] = new HashSet<char>();
                if (!squares.ContainsKey(squareIndex)) squares[squareIndex] = new HashSet<char>();
                if (rows[r].Contains(cell) || cols[c].Contains(cell) || squares[squareIndex].Contains(cell)) {
                    return false;
                }
                rows[r].Add(cell);
                cols[c].Add(cell);
                squares[squareIndex].Add(cell);
            }
        }
        return true;
    }
}
