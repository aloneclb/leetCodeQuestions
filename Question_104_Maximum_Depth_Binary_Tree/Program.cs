using System.Diagnostics;

var stopwatch = new Stopwatch();
stopwatch.Start();

var node6 = new TreeNode(4);
var node4 = new TreeNode(3);
var node2 = new TreeNode(2, node4, node6);

var node3 = new TreeNode(2);
var node5 = new TreeNode(3);
var node7 = new TreeNode(4, node5, node3);


var rootNode = new TreeNode(1, node2, node7);


var result = Solution.MaxDepth(rootNode);

Console.WriteLine(result);

stopwatch.Stop();
var elapsedTime = stopwatch.Elapsed;
var elapsedSeconds = elapsedTime.TotalSeconds;

Console.WriteLine(elapsedTime);
Console.WriteLine(elapsedSeconds);


public class TreeNode
{
    public int val;
    public TreeNode? left;
    public TreeNode? right;

    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}


public static class Solution
{
    public static int MaxDepth(TreeNode root)
    {
        if (root == null)
        {
            return 0; // Boş ağaçın derinliği 0
        }

        int leftDepth = MaxDepth(root.left); // Sol alt ağacın derinliğini hesapla
        int rightDepth = MaxDepth(root.right); // Sağ alt ağacın derinliğini hesapla
        return Math.Max(leftDepth, rightDepth) + 1; // Mevcut düğümün derinliği 1 artır
    }
}