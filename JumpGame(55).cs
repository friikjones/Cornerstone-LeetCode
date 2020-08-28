public class Solution {
    public bool CanJump(int[] nums) {
    int min = 0;
    for (int i = nums.Length - 2; i >= 0; i--)
    {
        if (nums[i] > min) min = 0;
        else min++;
    }
    return min == 0;
}
}