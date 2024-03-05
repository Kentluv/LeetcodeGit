
public class Exist_Solution {
    public bool Exist(char[][] board, string word) {
        var rows = board.Length;
        var cols = board[0].Length;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (Exist(board, i, j, word, 0))
                {
                    return true;
                }
            }
        }
        return false;
    }

    private bool Exist(char[][] board, int i, int j, string word, int v)
    {
        if (v == word.Length)
        {
            return true;
        }

        if (i < 0 || i >= board.Length || j < 0 || j >= board[0].Length || board[i][j] != word[v])
        {
            return false;
        }

        var temp = board[i][j];
        board[i][j] = ' ';
        var result = Exist(board, i + 1, j, word, v + 1) ||
                     Exist(board, i - 1, j, word, v + 1) ||
                     Exist(board, i, j + 1, word, v + 1) ||
                     Exist(board, i, j - 1, word, v + 1);
        board[i][j] = temp;
        return result;
    }
}