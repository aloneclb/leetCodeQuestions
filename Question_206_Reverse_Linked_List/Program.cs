using System.Diagnostics;

var stopwatch = new Stopwatch();
stopwatch.Start();

// Bağlı listeyi tanımla
ListNode head = new ListNode(1);
head.next = new ListNode(2);
head.next.next = new ListNode(3);
head.next.next.next = new ListNode(4);
head.next.next.next.next = new ListNode(5);

// Bağlı listeyi tersine çevir
Solution solution = new Solution();
ListNode result = solution.ReverseList(head);

Console.WriteLine(result);

stopwatch.Stop();
var elapsedTime = stopwatch.Elapsed;
var elapsedSeconds = elapsedTime.TotalSeconds;

Console.WriteLine(elapsedTime);
Console.WriteLine(elapsedSeconds);

public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}


public class Solution
{
    public ListNode ReverseList(ListNode head)
    {
        ListNode prev = null;
        ListNode current = head;
        while (current != null)
        {
            ListNode nextNode = current.next;
            current.next = prev;
            prev = current;
            current = nextNode;
        }

        return prev;
    }

    public ListNode ReverseList2(ListNode? head)
    {
        Stack<int> stack = new Stack<int>();
        ListNode current = head;
        while (current != null)
        {
            stack.Push(current.val);
            current = current.next;
        }

        if (stack.Count == 1)
        {
            return new ListNode(stack.Pop());
        }

        if (stack.Count > 1)
        {
            ListNode newHead = new ListNode(stack.Pop());
            ListNode temp = new ListNode(stack.Pop());
            newHead.next = temp;
            while (stack.Count > 0)
            {
                temp.next = new ListNode(stack.Pop());
                temp = temp.next;
            }

            return newHead;
        }

        return null;
    }
}