public static class Solution  {
  public static ListNode MergeTwoLists(ListNode list1, ListNode list2) {
      ListNode[] nextNodes = new[] { list1.next, list2.next};

      if(nextNodes[0] != null && nextNodes[1] != null) {
        var values = new int[2];
        if(nextNodes[0].val >= nextNodes[1].val) 
        {
            values[0] = nextNodes[1].val;
            values[1] = nextNodes[0].val;
        }
        else
        {
            values[1] = nextNodes[1].val;
            values[0] = nextNodes[0].val;
        }
        nextNodes[0] = new ListNode(values[0]);
        nextNodes[1] = new ListNode(values[1]);
        var node = MergeTwoLists(nextNodes[0], nextNodes[1]);
        return node;
      }
      else
      {
        //TODO: The algorithm is incomplete.
        if(nextNodes[0] == null)
        {
           return MergeTwoLists(nextNodes[1].next);
        }
      }
  }
}
