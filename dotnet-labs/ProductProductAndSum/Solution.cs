public static class Solution
{
	public static int[] ConvertNumberToArray(int number)
	{
		List<int> result = new List<int>();
		int algarismNumber = 0;
		int reference = number;
		
		do
		{
			algarismNumber = reference % 10;
			result.Add(algarismNumber);
			reference = (int)reference/10;
		}
		while(reference != 0);
		return result.ToArray<int>();
	}
	public static int SubtractProductionAndSum(int n)
	{
		var numberArray = Solution.ConvertNumberToArray(n);
		int sum = 0, product = 1;
		//get product
		for(int i = (numberArray.Length - 1); i > -1; i--)
		{
			sum =  sum + numberArray[i];
			product =  product * numberArray[i];
		}
		return product - sum;
	}
}