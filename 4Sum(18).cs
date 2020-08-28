public class Solution {
    public IList<IList<int>> FourSum(int[] nums, int target) 
{
    Array.Sort(nums);
    IList<IList<int>> lists = new List<IList<int>>();
    Find(nums, target, new int[4], 0, 0, 0, lists);
    return lists;
}

public void Find(int[] nums, int target, int[] curr, int currLen, int currSum, int index, IList<IList<int>> lists)
{
    if (currLen == 4) 
    {
        if (currSum == target)
        {
            lists.Add(new List<int>(curr));
        }
        return;
    }
    
    if (nums.Length > 0 && target - currSum > (4 - currLen) * nums[nums.Length - 1]) return;
    
    for (int i = index; i < nums.Length; i++)
    {
        if (target - currSum < (4 - currLen) * nums[i]) break;
        
        curr[currLen] = nums[i];
        Find(nums, target, curr, currLen + 1, currSum + nums[i], i + 1, lists);
        while (i < nums.Length - 1 && nums[i] == nums[i+1]) i++;
    }
}
}