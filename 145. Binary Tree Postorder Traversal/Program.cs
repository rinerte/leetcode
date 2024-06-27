public IList<int> PostorderTraversal(TreeNode root) {
        IList<int> preorderTraversal = new List<int>();
            if (root == null) return preorderTraversal;

            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);

            while (stack.Any())
            {
                var node = stack.Pop();
                preorderTraversal.Insert(0, node.val);
                if (node.left != null) stack.Push(node.left);
                if (node.right != null) stack.Push(node.right);
            }
            return preorderTraversal;
}