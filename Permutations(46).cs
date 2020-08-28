public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
    Array.Sort(nums);
    IList<IList<int>> lists = new List<IList<int>>();
    do
    {
        lists.Add(new List<int>(nums));
    }
    while (Next(nums));
    
    return lists;
}

public bool Next(int[] nums)
{
    // from the right find first elem that is decreasing
    int i = nums.Length - 1;
    while (i > 0 && nums[i] <= nums[i-1])
    {
        i--;
    }
    if (i == 0)
    {
        return false;
    }
    
    // from the right find first elem greater than elem before i
    // note we can omit checks for edges because we know this elem must exist
    int j = nums.Length - 1;
    while (nums[j] <= nums[i-1])
    {
        j--;
    }
    
    // swap these elems
    int temp = nums[j];
    nums[j] = nums[i-1];
    nums[i-1] = temp;
    
    // reverse the last set of elems between i and the end
    int left = i;
    int right = nums.Length - 1;
    while (left < right)
    {
        temp = nums[left];
        nums[left] = nums[right];
        nums[right] = temp;
        left++;
        right--;
    }
    
    return true;
}
}