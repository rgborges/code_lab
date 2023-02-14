int[] test1 = new[] {3, 2, 2, 3};

int val1 = 3;

var result = Solution.RemoveElement(test1, val1);

System.Console.WriteLine("Teste arr:{0} val:{1} result: {2}", string.Join(',', test1),val1, result);

int val2 = 2;

int[] test2 = new[] {0,1,2,2,3,0,4,2};

var result2 = Solution.RemoveElement(test2, val2);

System.Console.WriteLine("Teste arr:{0} val:{1} result: {2}", string.Join(',', test2),val2, result2);

var test3 = new[] {1};

int val3 = 1;

var result3 = Solution.RemoveElement(test3, val3);

System.Console.WriteLine("Teste arr:{0} val:{1} result: {2}", string.Join(',', test3),val3, result3);

Console.ReadLine();

