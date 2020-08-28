public class Solution {
    public string Convert(string s, int numRows) {
        if (s.Length <= numRows || numRows == 1) return s;
        int factor = 2 * numRows - 2;
        string response = string.Empty;
        for (int i = 0; i < numRows; i++)
        {
            for (int j = i; j < s.Length + factor; j += factor)
            {
                if (i > 0 && i < numRows - 1)
                {
                    if (j - i * 2 < s.Length && j > i)
                    {
                        response += s[j - i * 2];   
                    }
                }
                if (j < s.Length)
                {
                    response += s[j];
                }
            }
        }
        return response;
    }
}