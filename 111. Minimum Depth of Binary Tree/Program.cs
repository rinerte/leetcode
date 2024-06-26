// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public int MinDepth(TreeNode root) {
        if (root == null) return 0;
            Stack<(TreeNode node, int level) > stack = new Stack<(TreeNode node, int level)>();
            stack.Push((root, 1));
            int min = int.MaxValue;
            while (stack.Any())
            {
                var node = stack.Pop();
                if(node.level<min && node.node.left==null && node.node.right==null) min = node.level;
                if (node.node.left != null) stack.Push((node.node.left, node.level + 1));
                if (node.node.right != null) stack.Push((node.node.right, node.level + 1));
            }
            return min;        
}