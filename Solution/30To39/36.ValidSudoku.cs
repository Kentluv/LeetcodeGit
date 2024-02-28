
using System.Globalization;

public class IsValidSudoku_Solution {
    public bool IsValidSudoku(char[][] board) {
        for(var i=0; i<9; i++)
        {
            var row = new bool[9];
            var col = new bool[9];
            var block = new bool[9];
            for(var j=0; j<9; j++)
            {
                if(board[i][j] != '.')
                {
                    if(row[board[i][j]-'1'])
                        return false;
                    row[board[i][j]-'1'] = true;
                }
                if(board[j][i] != '.')
                {
                    if(col[board[j][i]-'1'])
                        return false;
                    col[board[j][i]-'1'] = true;
                }
                var r = 3*(i/3);
                var c = 3*(i%3);
                if(board[r+j/3][c+j%3] != '.')
                {
                    if(block[board[r+j/3][c+j%3]-'1'])
                        return false;
                    block[board[r+j/3][c+j%3]-'1'] = true;
                }
            }
        }
        return true;
    }

    
}