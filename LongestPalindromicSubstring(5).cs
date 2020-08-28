public class Solution 
{
    public string LongestPalindrome(string s) 
    {
        if(String.IsNullOrEmpty(s))
            return string.Empty;
        
        string pal = s.Substring(0, 1);
        int max = 1;
        
        for(int i = 0; i < s.Length; ++i)
        {
            int j = 0;
            
            // Even-length palindromes with s[i] in the middle
            while(i - j >= 0 && i + j + 1 < s.Length && s[i - j] == s[i + j + 1])
            {
                if(2 * j + 2 > max)
                {
                    max = 2 * j + 2;
                    pal = s.Substring(i - j, max);
                }
                
                ++j;
            }
            
            j = 0;
            // Odd-length palindromes with s[i] in the middle
            while(i - j - 1 >= 0 && i + j + 1 < s.Length && s[i - j - 1] == s[i + j + 1])
            {
                if(2 * j + 3 > max)
                {
                    max = 2 * j + 3;
                    pal = s.Substring(i - j - 1, max);
                }
                
                ++j;
            }
        }
        
        return pal;
    }
}