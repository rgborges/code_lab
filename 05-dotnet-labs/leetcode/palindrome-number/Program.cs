// See https://aka.ms/new-console-template for more information

var tests = new[] {121, 1441, 0, 10, 1, 2, 35, 16 , 11, 12, 100, 1_000};

for (int i = 0; i < tests.Length; i++)
{
      System.Console
            .WriteLine("Is {0} a palindrome {1}", 
                        tests[i], Solution.isPalindrome(tests[i]));
}