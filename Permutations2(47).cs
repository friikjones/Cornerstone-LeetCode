public class Solution {
    private IList<IList<int>> result = new List<IList<int>>();
    
    public IList<IList<int>> PermuteUnique(int[] nums) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
                
        foreach (var item in nums)
        {
            if (!dict.ContainsKey(item))
                dict.Add(item, 0);
            
            dict[item] += 1;
        }
        
        int[][] set = new int[dict.Count][];
        int i = 0;
        
        foreach (var item in dict.Keys)
            set[i++] = new int[] { item, dict[item] };
        
        Helper(set, new List<int>(), nums.Length);
        
        return result;
    }
    
    private void Helper(int[][] set, List<int> cur, int count)
    {
        if (cur.Count == count)
        {
            result.Add(new List<int>(cur));
            return;
        }
        
        foreach (var item in set)
            if (item[1] != 0)
            {
                item[1] -= 1;
                cur.Add(item[0]);
                
                Helper(set, cur, count);
                
                item[1] += 1;
                cur.RemoveAt(cur.Count - 1);
            }
    }
}