//k -> is the total number that you need to skip in order to get the array with the itens removed
//x:  as the number of itens excluded
//nums[]: input array
//val = val to be removed
public static class Solution
{
  public static int RemoveElement(int[] nums, int val)
  {
    int count = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] != val)
            {
                nums[count] = nums[i];
                count ++;
            }
        }
        return count;
      }
  }

// 3, 2, 2, 3 -> val =3 ->  2, 2, 3, 3 k 2
// 0, 1, 2, 2, 3, 0, 4, 2 val=2 ->

// 0, 1, 4, 2, 3, 0, 2, 2
// 0, 1, 4, 0, 3, 2, 2, 2
//
