public class Solution {
    private IList<int> result = new List<int>();
    
    public IList<int> SpiralOrder(int[][] matrix) {
        if (matrix == null || matrix.Length == 0)
            return new List<int>();
        
        DFS(matrix, 0, 0, new bool[matrix.Length, matrix[0].Length], 'R', 1);
        
        return result;
    }
    
    private void DFS(int[][] matrix, int i, int j, bool[,] visited, char direction, int n)
    {
        if (n > matrix.Length * matrix[0].Length)
            return;
        
        result.Add(matrix[i][j]);
        visited[i, j] = true;
        
        if (direction == 'R' && (j + 1 == matrix[0].Length || visited[i, j + 1]))
            direction = 'D';
        else if (direction == 'L' && (j - 1 < 0 || visited[i, j - 1]))
            direction = 'U';
        else if (direction == 'U' && (i - 1 < 0 || visited[i - 1, j]))
            direction = 'R';
        else if (direction == 'D' && (i + 1 == matrix.Length || visited[i + 1, j]))
            direction = 'L';
        
        if (direction == 'R')
            DFS(matrix, i, j + 1, visited, direction, n + 1);
        else if (direction == 'L')
            DFS(matrix, i, j - 1, visited, direction, n + 1);
        else if (direction == 'U')
            DFS(matrix, i - 1, j, visited, direction, n + 1);
        else
            DFS(matrix, i + 1, j, visited, direction, n + 1);
    }
}