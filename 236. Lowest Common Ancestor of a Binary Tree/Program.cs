// Given a binary tree, find the lowest common ancestor (LCA) of two given nodes in the tree.

// According to the definition of LCA on Wikipedia: “The lowest common ancestor is defined between two nodes p and q as the lowest node in T that has both p and q as descendants (where we allow a node to be a descendant of itself).”
public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
    TreeNode lowest = root;

    Stack<TreeNode> stack = new();
    stack.Push(root);

    while(stack.Any()){
        var n = stack.Pop();
        if(n.left!=null && CanReach(n.left,p,q)){
            stack.Push(n.left);
            lowest = n.left;
        }
        if(n.right!=null && CanReach(n.right,p,q)){
            stack.Push(n.right);
            lowest = n.right;
        }
    }
    return lowest;
}

bool CanReach(TreeNode node, TreeNode p, TreeNode q){
    if(node==null) return false;
    bool pr = false;
    bool qr = false;

    Stack<TreeNode> stack = new();
    stack.Push(node);
    while(stack.Any()){
        var n = stack.Pop();
        if(n==p) pr = true;
        if(n==q) qr=true;
        if(n.left!=null) stack.Push(n.left);
        if(n.right!=null) stack.Push(n.right);
    }
    return (pr && qr);
}