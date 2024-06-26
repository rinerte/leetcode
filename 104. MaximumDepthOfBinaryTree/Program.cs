// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


public static int MaxDepth(TreeNode root)
{
    int max = 0;
    if (root == null) return 0;
    Stack<(TreeNode node,int level)> stack = new Stack<(TreeNode, int level)>();
    stack.Push((root, 1));

    while (stack.Any())
    {
        var element = stack.Pop();
        if(element.level>max) max= element.level;
        if(element.node.left!=null)
            stack.Push((element.node.left,element.level+1));
        if (element.node.right != null)
            stack.Push((element.node.right, element.level + 1));
    }
    return max;
}

public class TreeNode {
                public int val;
                public TreeNode left;
                public TreeNode right;
                public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
                    this.val = val;
                    this.left = left;
                    this.right = right;
            }
}