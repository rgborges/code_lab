using System;
using PlayWithNode;

// See https://aka.ms/new-console-template for more information

int[] inArr = new int[] {2, 34, 54 ,23, 43, 2343, 234, 34, 4};
var node = new TreeNode(0);
for(int i = 0; i < inArr.Length; i++)
{
     Solution.AddValue(inArr[i], ref node);
} 