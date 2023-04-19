namespace PlayWithNode;

public static class Solution
{
      public static void AddValue(int value,ref TreeNode treeNode)
      {
            
            if (treeNode.Next is null)
            {
                  treeNode.Next = new TreeNode(value);
                  return;
            }
            AddValue(value, ref treeNode.Next);
      } 
}

public class TreeNode 
{
      public int Value = 0;
      public TreeNode Next = null;
       public TreeNode(int value, TreeNode next = null)
      {
            this.Value = value;
            this.Next = next;
      }
}