public class Solution {
    public bool IsValidSudoku(char[][] board) {
     
        for (int i = 0; i < board.Length; i++)
        {
            HashSet<int> colHs = new HashSet<int>();
            HashSet<int> rowHs = new HashSet<int>();
        
            for (int j = 0; j < board[i].Length; j++)
            {
                if (board[i][j] != '.')
                {
                    if (colHs.Contains(board[i][j])) return false; 
                    colHs.Add(board[i][j]);    
                }
                
                if (board[j][i] != '.') 
                {
                    if (rowHs.Contains(board[j][i])) return false; 
                    rowHs.Add(board[j][i]);    
                }                              
            }
        }
        
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                HashSet<int> boxHs = new HashSet<int>();
                for (int k = 0; k < 3; k++)
                {
                    for (int l = 0; l < 3; l++)
                    {
                        if (board[k + i * 3][l + j * 3] != '.')
                        {
                            if (boxHs.Contains(board[k + i * 3][l + j * 3])) return false;
                            boxHs.Add(board[k + i * 3][l + j * 3]);
                        }
                    }
                }                
            }
        }        
        
        return true;   
    }
}