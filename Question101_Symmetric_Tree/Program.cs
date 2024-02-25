// See https://aka.ms/new-console-template for more information

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


var result = Solution.IsSymmetric(rootNode);

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
    public static bool IsSymmetric(TreeNode root) {
        if (root == null) {
            return true; // Boş ağaç simetriktir
        }
        return IsMirror(root.left, root.right);
    }

    private static  bool IsMirror(TreeNode? left, TreeNode? right) {
        if (left == null && right == null) {
            return true; // Her iki düğüm de boşsa, simetrik kabul edilir
        }
        if (left == null || right == null || left.val != right.val) {
            return false; // Bir düğüm boşsa veya değerleri eşleşmiyorsa, simetrik değildir
        }
        // Sol alt ağacın sol düğümü ve sağ alt ağacın sağ düğümü arasında simetri kontrolü yapılır
        return IsMirror(left.left, right.right) && IsMirror(left.right, right.left);
    }
    
    public static bool IsSymmetric2(TreeNode? root) {
        if (root == null) {
            return true; // Boş ağaç simetriktir
        }
        
        Queue<TreeNode?> queue = new();
        queue.Enqueue(root.left);
        queue.Enqueue(root.right);

        while (queue.Count > 0) {
            TreeNode? leftNode = queue.Dequeue();
            TreeNode? rightNode = queue.Dequeue();

            if (leftNode == null && rightNode == null) {
                continue; // Her iki düğüm de boşsa, simetrik kabul edilir
            }
            if (leftNode == null || rightNode == null || leftNode.val != rightNode.val) {
                return false; // Bir düğüm boşsa veya değerleri eşleşmiyorsa, simetrik değildir
            }

            // Her iki alt ağacın düğümleri sıraya eklenir
            queue.Enqueue(leftNode.left);
            queue.Enqueue(rightNode.right);
            queue.Enqueue(leftNode.right);
            queue.Enqueue(rightNode.left);
        }

        return true;
    }
}