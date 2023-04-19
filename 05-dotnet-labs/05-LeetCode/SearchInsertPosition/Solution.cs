namespace SearchInsertPosition
{
      public static class Solution
      {
            public static int SearchInsert(int[] nums, int target)
            {
                  for (int i = 0; i < nums.Length; i++)
                  {
                        if(nums[i] == target)
                        {
                              return i;
                        }
                  }
                  return nums.Length;
            }
      }
}