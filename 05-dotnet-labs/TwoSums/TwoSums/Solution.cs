public static class Solution 
{
      public static int[] TwoSum(int[] nums, int target)
      {
            //para cada numero em nums, verifica se a soma e igual ao target de todos os numeros
            //se sim para looping e retornar o resultado 
            for(int i = 0; i < nums.Length; i++)
            {
                  for(int j = i+1; j < nums.Length; j++)
                  {
                        if(nums[i] + nums[j] == target)
                        {
                              return new int[] {i, j};
                        }
                  }
            } 
            return new int[] {0};
      }
}