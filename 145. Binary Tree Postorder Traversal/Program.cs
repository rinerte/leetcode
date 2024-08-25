//Given the root of a binary tree, return the postorder traversal of its nodes' values.

public class Solution
{
    public IList<int> PostorderTraversal(TreeNode root)
    {

        Stack<TreeNode> s = new();
        List<int> l = new();
        if (root == null) return l;

        s.Push(root);
        while (s.Any())
        {
            var node = s.Pop();
            if (node.left != null) s.Push(node.left);
            if (node.right != null) s.Push(node.right);
            l.Add(node.val);
        }
        l.Reverse();
        return l;
    }
}