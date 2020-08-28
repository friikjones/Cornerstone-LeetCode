public class Solution {
    public int Search(int[] nums, int target)
    {
        if (nums == null || nums.Length == 0)
        {
            return -1;
        }

        int start = 0;
        int end = nums.Length - 1;

        while (start <= end)
        {
            // To avoid overflow
            int mid = start + (end - start) / 2;

            if (nums[mid] == target) 
            {
                return mid;
            }

            // which part of the array target exists, left rising or right rotated?
            if (target >= nums[0])
            {
                // left part, rising one

                // if mid is at the left side of the array?
                if (nums[mid] < nums[0])
                {
                    // wrong side, adjust end
                    end = mid - 1;
                }
                else
                {
                    // good, rotated side, do regular binary search
                    if (nums[mid] > target)
                    {
                        end = mid - 1;
                    }
                    else
                    {
                        start = mid + 1;
                    }
                }
            }
            else
            {
                // right part, rotated

                // if mid is at the right side of the array?
                if (nums[mid] >= nums[0])
                {
                    // wrong side, adjust start
                    start = mid + 1;
                }
                else
                {
                    // good, rising side, do regular binary search
                    if (nums[mid] > target)
                    {
                        end = mid - 1;
                    }
                    else
                    {
                        start = mid + 1;
                    }
                }
            }
        }

        return -1;
    }
}