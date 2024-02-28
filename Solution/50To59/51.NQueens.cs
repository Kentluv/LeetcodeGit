

public class SolveNQueens_Solution {
    public IList<IList<string>> SolveNQueens(int n) {
        var result = new List<IList<string>>();
        var board = new char[n][];
        for (int i = 0; i < n; i++)
        {
            board[i] = new char[n];
            for (int j = 0; j < n; j++)
            {
                board[i][j] = '.';
            }
        }
        SolveNQueensHelper(result, board, 0);
        return result;
    }

    private void SolveNQueensHelper(List<IList<string>> result, char[][] board, int v)
    {
        if(v == board.Length)
        {
            var list = new List<string>();
            for (int i = 0; i < board.Length; i++)
            {
                list.Add(new string(board[i]));
            }
            result.Add(list);
            return;
        }
        for (int i = 0; i < board.Length; i++)
        {
            if(IsValid(board, v, i))
            {
                board[v][i] = 'Q';
                SolveNQueensHelper(result, board, v + 1);
                board[v][i] = '.';
            }
        }
    }

    private bool IsValid(char[][] board, int v, int i)
    {
        for (int j = 0; j < v; j++)
        {
            if(board[j][i] == 'Q') return false;
        }
        for (int j = v - 1, k = i - 1; j >= 0 && k >= 0; j--, k--)
        {
            if(board[j][k] == 'Q') return false;
        }
        for (int j = v - 1, k = i + 1; j >= 0 && k < board.Length; j--, k++)
        {
            if(board[j][k] == 'Q') return false;
        }
        return true;
    }
}