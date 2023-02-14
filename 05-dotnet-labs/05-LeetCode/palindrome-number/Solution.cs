public static class Solution 
{
	public static bool isPalindrome(int x)
	{
//Oficial solution 

  if(x < 0 || (x % 10 == 0 && x != 0)) {
    return false;
  }

  int revertedNumber = 0;
  while (x > revertedNumber) {
    revertedNumber = revertedNumber * 10 + x % 10;
    x /= 10;
  }

  return x == revertedNumber || x == revertedNumber / 10;



    // var result = false;
		
    // if(x < 0 || (x % 10 == 0)) {
		// 	return result;
		// }
    // int mod = x;
    // int alg = 0;
    // var temparr = new List<int>();
    
    // do {
    //   mod = (int)x % 10;
    //   if(mod == 0) break;
    //   temparr.Add(mod);
    //   x = x/10;
    //   alg++;
    // }while (!(mod % 10 == 0));

    // var arr = temparr.ToArray<int>();
    
    // if (arr.Length == 0) return true;
    
    // int j = arr.Length - 1;

    // for(int i = 0; i < arr.Length; i++, j--)
    // {
    //   if(arr[i] == arr[j]) {
    //     result = true;
    //   }
    //   else {
    //     result = false;
    //   }
    //   if(i+1 >= (int)arr.Length/2) break;
    // }
		// return result;
	}
}

