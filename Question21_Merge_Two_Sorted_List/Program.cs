using System.Diagnostics;

var stopwatch = new Stopwatch();

ListNode? startNode = null;


var startNode2 = new ListNode(0);

stopwatch.Start();

var result = Solution.MergeTwoLists(startNode, startNode2);
Console.WriteLine(result);

stopwatch.Stop();
var elapsedTime = stopwatch.Elapsed;
var elapsedSeconds = elapsedTime.TotalSeconds;

Console.WriteLine(elapsedTime);
Console.WriteLine(elapsedSeconds);


public class ListNode
{
    public int val;
    public ListNode? next;

    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public static class Solution
{
    public static ListNode? MergeTwoLists(ListNode? list1, ListNode? list2)
    {
        if (list1 == null && list2 == null)
            return null;
        
        var list = new List<int>();

        var temp = list1;
        while (temp != null)
        {
            list.Add(temp.val);
            if (temp.next == null)
                break;
            temp = temp.next;
        }

        var temp2 = list2;
        while (temp2 != null)
        {
            list.Add(temp2.val);
            if (temp2.next == null)
                break;
            temp2 = temp2.next;
        }

        list = list.OrderBy(x => x).ToList();
        var resultNode = new ListNode();
        var tempNode = new ListNode();
        for (int i = 0; i < list.Count; i++)
        {
            if (i == 0)
            {
                resultNode.val = list[i];
                resultNode.next = tempNode;
            }
            else if (i != list.Count - 1)
            {
                tempNode.val = list[i];
                tempNode.next = new ListNode();
                tempNode = tempNode.next;
            }
            else
            {
                tempNode.val = list[i];
            }
        }

        if (list.Count == 1)
        {
            resultNode.next = null;
        }
        return resultNode;
    }
}