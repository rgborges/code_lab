// See https://aka.ms/new-console-template for more information
 

var inputValue = new List<ListNode>(10);

// sample - 01
inputValue.Add(new ListNode(1, new ListNode(2, new ListNode(4))));

//sample - 02
inputValue.Add(new ListNode(1, new ListNode(3, new ListNode(4))));


for (int i = 0; i < inputValue.Count; i++)
{
      //Verifica sempre se há dois valores
      if(i + 1 < inputValue.Count - 1) {
            var result = inputValue[i];
            PrintListNode(result);
      }
      else {
            break;
      }

}


static void PrintListNode(ListNode node)
{
      var next = new object();
      do
      {
            System.Console.Write("{0} ", node.val);
            next = node.next as ListNode;
      } while(next != null);
}



