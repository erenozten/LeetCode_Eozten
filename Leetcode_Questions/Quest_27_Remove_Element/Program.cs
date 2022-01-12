public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        int increase = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[increase] = nums[i];
                increase++;
            }
        }
        return increase;
    }
}

