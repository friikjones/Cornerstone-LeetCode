public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
    IList<IList<int>> ls = new List<IList<int>>();        
    int l = nums.Length;
    Array.Sort(nums);
    int[] p = new [] { int.MaxValue, int.MaxValue };

    for(int i = 0; i < l - 2; ++i)
    {    
        if(p[0] == nums[i])
            continue;
        p[0] = nums[i];
        p[1] = int.MaxValue;
        int k = l - 1;
        for(int j = i + 1; j < k; ++j)
        {
            if(p[1] == nums[j])
                continue;
            
            while(j < k && nums[i] + nums[j] + nums[k] < 0)
                ++j;
            while(j < k && nums[i] + nums[j] + nums[k] > 0)
                --k;
            if(j < k && nums[i] + nums[j] + nums[k] == 0)
                ls.Add(new List<int> { nums[i], nums[j], nums[k]});
            p[1] = nums[j];
        }
    }
    
    return ls;
}
}