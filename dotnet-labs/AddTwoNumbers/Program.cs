// See https://aka.ms/new-console-template for more information
var input01 = new int[] { 2, 4, 3};
var input02 = new int[] { 5, 6, 4};

var solution = new Solution();
var service = new ListNodeService();
var node1 = service.ToListNode(input01);
var node2 = service.ToListNode(input02);

ListNode sum = solution.AddTwoNumbers(node1, node2);+
//finish
Console.ReadLine();