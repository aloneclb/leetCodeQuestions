// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");


public class TreeNode
{
    public int val;
    public TreeNode? left;
    public TreeNode? right;

    public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution
{
    public IList<int> InorderTraversal(TreeNode root) {
        IList<int> result = new List<int>();
        InorderTraversalHelper(root, result);
        return result;
    }
    
    private void InorderTraversalHelper(TreeNode? node, IList<int> result) {
        if (node == null) return;
        
        InorderTraversalHelper(node.left, result); // Sol alt ağacı keşfet
        result.Add(node.val); // Kök düğümü ziyaret et
        InorderTraversalHelper(node.right, result); // Sağ alt ağacı keşfet
    }
}