public class Solution {
    public void Rotate(int[][] matrix)
        {
           //get matrix's size to make the code clear, you don't have to be like this
            int size = matrix.Length-1;

            for (int i = 0; i < matrix.Length/2; i++)
            {
                for (int j = i; j < size-i; j++)
                {

                    //Circle the number to correct position
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[size-j][i];
                    matrix[size-j][i] = matrix[size-i][size-j];
                    matrix[size-i][size-j] = matrix[j][size-i];
                    matrix[j][size-i] = temp;

                }
            }
        }
}