public IList<int> InorderTraversal(TreeNode root) {
    var list = new List<int>();
    InorderTraverseIteratively(root, list);
    return list;
}
    
private void InorderTraverseIteratively(TreeNode root, IList<int> list)
{
    var current = root;
    var stack = new Stack<TreeNode>();

    while (current != null || stack.Count > 0)
    {
        while (current != null)
        {
            stack.Push(current);
            current = current.left;
        }
        var top = stack.Pop();
        list.Add(top.val);
        current = top.right;
    }
}