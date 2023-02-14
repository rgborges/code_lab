public class ListNode
{
      public int val;
      public ListNode next;
      public ListNode(int value = 0, ListNode node = null)
      {
            this.val = value;
            this.next = node;     
      }
}
public class ListNodeService
{
      public ListNode ToListNode(int[] input)
      {
            var result = new ListNode();
            ListNode temp = result;
            for(int i = 0; i < input.Length; i++)
            {
                  if(i == 0)
                  {
                        temp.val = input[i];
                  }
                  else
                  {
                        if(temp.next is null)
                        {
                              temp.next = new ListNode(input[i]);
                              temp = temp.next;
                        }
                        else
                        {
                              temp.val = input[i];
                        }
                  }
            }
            return result;
      }
      public ListNode GetLast(ListNode list)
      {
            var temp = list;
            do
            {
                  if(temp.next is not null)
                  {
                       temp = temp.next;
                  }
                  else
                  {
                        return temp;
                  }
            }while(true);
      }
      public ListNode RemoveLast(ListNode list)
      {
            ListNode temp = list;
            ListNode result;
            do
            {
                  if(temp.next is not null)
                  {
                       temp = temp.next;
                  }
                  else
                  {
                        result = temp;
                        temp = null; 
                        return result;
                  }
            }while(true);
      }
}
public class Solution
{
      public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
      {
            var service = new ListNodeService();
            Stack<int> resultFromL1 = new Stack<int>();
            Stack<int> resultFromL2 = new Stack<int>();
            int fullValL1 = 0;
            int fullValL2 = 0;
            int sum = 0;
            //TODO: Get the numbers from first node
            do 
            {
                  resultFromL1.Push(l1.val);
            }while (l1.next is not null);
            do
            {
                  resultFromL2.Push(l2.val);
            } while(l2.next is not null);
            //TODO: Restore values as full integers
            for(int mul = resultFromL1.Count - 1; mul <= 0; mul--)
            {
                  fullValL1 = fullValL1 + (resultFromL1.Pop() * 10^mul);
            }
            for(int mul = resultFromL2.Count - 1; mul <= 0; mul--)
            {
                  fullValL2 = sum + (resultFromL2.Pop() * 10^mul);
            }

            sum = fullValL1 + fullValL2;
            


      }
}