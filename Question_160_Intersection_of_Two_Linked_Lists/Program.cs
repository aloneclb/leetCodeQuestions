using System.Diagnostics;

var stopwatch = new Stopwatch();
stopwatch.Start();

Console.WriteLine(3 ^ 5);


var node4 = new ListNode(-1, null);
var node3 = new ListNode(2, node4);
var node2 = new ListNode(3, node3);
var node1 = new ListNode(4, node2);
var root = new ListNode(1, node1);

node4.next = root;

var result = Solution.GetIntersectionNode(root, root);

Console.WriteLine(result.val);

stopwatch.Stop();
var elapsedTime = stopwatch.Elapsed;
var elapsedSeconds = elapsedTime.TotalSeconds;

Console.WriteLine(elapsedTime);
Console.WriteLine(elapsedSeconds);


public class ListNode(int x, ListNode? next)
{
    public int val = x;
    public ListNode? next = next;
}


// 1- İlk olarak, her iki listedeki düğüm sayısını hesaplayacağız.
// 2- Daha sonra, listedeki düğüm sayısının farkını bulacağız ve bu fark kadar ileri gitmek için daha kısa olan listeden başlayacağız.
// 3- Ardından, iki listedeki her bir düğümü sırayla karşılaştıracağız. İlk kesişen düğümü bulduğumuzda, bu düğümü döndüreceğiz.

// iki bağlı listeyi aynı indexe kadar getir sonra kontrol ederek ilerle!

public static class Solution
{
    public static ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        int lengthA = GetLength(headA);
        int lengthB = GetLength(headB);

        int diff = Math.Abs(lengthA - lengthB);

        if (lengthA > lengthB) {
            while (diff-- > 0) {
                headA = headA.next;
            }
        } else {
            while (diff-- > 0) {
                headB = headB.next;
            }
        }

        while (headA != null && headB != null) {
            if (headA == headB) {
                return headA;
            }
            headA = headA.next;
            headB = headB.next;
        }

        return null;
    }

    private static int GetLength(ListNode head) {
        int length = 0;
        while (head != null) {
            length++;
            head = head.next;
        }
        return length;
    }
}