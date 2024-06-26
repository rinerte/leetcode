
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

public bool IsSymmetric(TreeNode root) {
    if (root.left==null && root.right!=null || root.left!=null && root.left==null || root.left?.val != root.right?.val)
            return false;

        if (root.left == null && root.right == null) return true;

        Stack<TreeNode> stack = new Stack<TreeNode>();
        stack.Push(root.left);

        StringBuilder sbLeftBranch = new StringBuilder("");
        StringBuilder sbRightBranch = new StringBuilder("");


        while(stack.Count > 0)
        {
            TreeNode node = stack.Pop();
            sbLeftBranch.Append(node.val);

            if(node.left!=null && node.right==null)
                sbLeftBranch.Append("L");
            else if(node.left == null && node.right != null)
                sbLeftBranch.Append("R");

            if (node.right != null) stack.Push(node.right);
            if (node.left!=null) stack.Push(node.left);
        }

        stack.Push(root.right);

        while (stack.Count > 0)
        {
            TreeNode node = stack.Pop();
            sbRightBranch.Append(node.val);

            if (node.left != null && node.right == null)
                sbRightBranch.Append("R");
            else if (node.left == null && node.right != null)
                sbRightBranch.Append("L");
            if (node.left != null) stack.Push(node.left);
            if (node.right != null) stack.Push(node.right);
        }

        return String.Compare(sbLeftBranch.ToString(),sbRightBranch.ToString())==0;        
}