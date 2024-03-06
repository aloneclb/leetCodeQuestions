using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

var stopwatch = new Stopwatch();
stopwatch.Start();

Console.WriteLine(3 ^ 5);


var node4 = new ListNode(-1, null);
var node3 = new ListNode(2, node4);
var node2 = new ListNode(3, node3);
var node1 = new ListNode(4, node2);
var root = new ListNode(1, node1);

node4.next = root;

var result = Solution.HasCycle(root);

Console.WriteLine(result);

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

/*
 *
 * Verilen bir bağlı listede döngü olup olmadığını belirlemek için bağlı listedeki herhangi bir düğüme, sürekli
 * olarak bir sonraki işaretçiyi takip ederek yeniden ulaşılıp ulaşılamayacağını kontrol etmemiz gerekiyor. Döngü varsa,
 * sonunda döngüde bir yerde iki işaretçi birbirine ulaşacaktır. Bu sorunu çözmek için Floyd'un Tavşan ve Kaplumbağa
 * algoritması, yani "iki işaretçi" tekniğini kullanacağız. Bu algoritma, biri diğerinin iki katı hızda hareket eden
 * iki işaretçi kullanır. Eğer bağlı listede döngü varsa, hızlı işaretçi sonunda döngünün içinde yavaş işaretçiyle
 * bir yerde buluşacaktır.
 */

public static class Solution
{
    public static bool HasCycle(ListNode? head)
    {
        if (head?.next == null)
        {
            return false;
        }

        ListNode slow = head;
        ListNode fast = head.next;

        while (fast != null && fast.next != null)
        {
            if (slow == fast)
            {
                return true;
            }

            slow = slow.next;
            fast = fast.next.next;
        }

        return false;
    }


    public static bool HasCyle2(ListNode? head)
    {
        // Kümeler teorisini kullanarakta çözebiliriz.
        if (head?.next == null)
        {
            return false;
        }

        HashSet<ListNode> uniqueList = new HashSet<ListNode>();
        ListNode? temp = head;
        while (temp != null && temp.next != null)
        {
            
            var isExist = uniqueList.Add(temp);
            if (isExist == false)
            {
                return true;
            }
            temp = temp.next;
        }

        return false;
    }
}