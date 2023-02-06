using BinaryTree.Services;
using BinaryTree.Models;
// See https://aka.ms/new-console-template for more information

int[] arr = new int[] { 12, 14, 35, 64, 65, 45, 128, 45, 234};

var service = new GenerateTreeNodeService();
var tree = service.SerializeTreeNode(arr);

System.Console.WriteLine("Treenode mouted.");
