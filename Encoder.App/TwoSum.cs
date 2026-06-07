namespace Encoder.App;

public static class TwoSum
{
    public static (int, int) FindTwoSum(int[] nums, int target)
    {
        var wagon = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if (wagon.ContainsKey(complement))
            {
                return (wagon[complement], i);
            }
            wagon[nums[i]] = i;
        }
        
        return (-1, -1);
}


}

