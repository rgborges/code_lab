using System;
using BinaryTree.Models;

namespace BinaryTree.Services;


public class GenerateTreeNodeService
{
    public BinaryTree.Models.TreeNode SerializeTreeNode(int[] arr)
    {
        Array.Sort(arr);
        int rootElement = arr[(int)arr.Length/2];
        BinaryTree.Models.TreeNode tree = new BinaryTree.Models.TreeNode(rootElement);
        for (int i = 0; i < arr.Length; i++)
        {
            if(arr[i] != rootElement)
            {
                tree.AddValue(arr[i]);
            }
        }
        return tree;
    }
}