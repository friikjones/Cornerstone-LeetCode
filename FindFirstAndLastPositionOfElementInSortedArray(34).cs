public class Solution {
    public int[] SearchRange(int[] nums, int target) {
    return new int[] { Find(nums, true, 0, nums.Length - 1, target), Find(nums, false, 0, nums.Length - 1, target) };
}

public int Find(int[] nums, bool leftmost, int left, int right, int target)
{
    if (right < left) return -1;
    
    int mid = (left + right) / 2;
    if (nums[mid] < target)
    {
        return Find(nums, leftmost, mid + 1, right, target);
    }
    else if (nums[mid] > target)
    {
        return Find(nums, leftmost, left, mid - 1, target);
    }
    else // equals
    {
        if (leftmost && mid > 0 && nums[mid - 1] == target)
        {
            return Find(nums, leftmost, left, mid - 1, target);
        }
        else if (!leftmost && mid < nums.Length - 1 && nums[mid + 1] == target)
        {
            return Find(nums, leftmost, mid + 1, right, target);
        }
        else
        {
            return mid;
        }
    }
}
}