// See https://aka.ms/new-console-template for more information


int[] input = new int[] {2,7,11,15};
int[] input2 = new int[] {3,2,4};


try
{
      int[] result = Solution.TwoSum(input2, 6);
      System.Console.Write("[");
      for(int i = 0; i < result.Length; i++)
      {
            System.Console.Write("{0},", result[i]);
      }
      System.Console.WriteLine("]");
}
catch
{

}