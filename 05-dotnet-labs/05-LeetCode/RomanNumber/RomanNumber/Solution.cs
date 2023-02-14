public static class Solution
{
      //converts a roman string expression into an integer
      public static int RomanToInt(string s)
      {
            //defines rules
            Dictionary<char, int> RomanSymblesValue = new Dictionary<char, int>();
            RomanSymblesValue.Add('I', 1);
            RomanSymblesValue.Add('V', 5);
            RomanSymblesValue.Add('X', 10);
            RomanSymblesValue.Add('L', 50);
            RomanSymblesValue.Add('C', 100);
            RomanSymblesValue.Add('D', 500);
            RomanSymblesValue.Add('M', 1000);
            char[] currentRuleForSub = {'V', 'X', 'L','C','D', 'M'};
            char[] backwardRuleForSub = {'C', 'X', 'I'};
            Dictionary<char, char[]> BackwardRule = new Dictionary<char, char[]>();
            BackwardRule.Add('I', new char[] {'V', 'X'});
            BackwardRule.Add('C', new char[] {'D', 'M'});
            BackwardRule.Add('X', new char[] {'L', 'C'});
            Stack<int> result = new Stack<int>();
            //process
            for(int i = 0; i < s.Length; i++)
            {
                  //anlyze the current one
                  if(i == 0)
                   {
                        result.Push(RomanSymblesValue[s[i]]);
                        continue;
                   }
                  if(currentRuleForSub.Contains(s[i]))
                   {
                        if(backwardRuleForSub.Contains(s[i-1]))
                        {
                              
                              var rule = BackwardRule[s[i-1]];
                              if(rule.Contains(s[i]))
                              {
                                    result.Pop();
                                    result.Push(RomanSymblesValue[s[i]] - RomanSymblesValue[s[i-1]]); 
                              }
                              else
                              {
                                    result.Push(RomanSymblesValue[s[i]]);      
                              }
                        }
                        else
                        {
                              result.Push(RomanSymblesValue[s[i]]);
                        }    
                   }
                  else if(backwardRuleForSub.Contains(s[i]))
                  {
                        result.Push(RomanSymblesValue[s[i]]);
                        continue;
                  }
                  else
                  {
                         result.Push(RomanSymblesValue[s[i]]);
                  }
            }
            return result.Sum();
      }
}