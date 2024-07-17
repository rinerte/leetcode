// Consider all the leaves of a binary tree, from left to right order, the values of those leaves form a leaf value sequence.



// For example, in the given tree above, the leaf value sequence is (6, 7, 4, 9, 8).

// Two binary trees are considered leaf-similar if their leaf value sequence is the same.

// Return true if and only if the two given trees with head nodes root1 and root2 are leaf-similar.
public bool LeafSimilar(TreeNode root1, TreeNode root2) {
    Stack<TreeNode> stack = new();        
    StringBuilder s1 = new();
    StringBuilder s2 = new();

    if(root1!=null) stack.Push(root1);
    while(stack.Any()){
        var node = stack.Pop();
        if(node.left!=null) stack.Push(node.left);
        if(node.right!=null) stack.Push(node.right);
        if(node.right==null &&node.left==null) s1.Append(node.val.ToString());
    }
    if(root2!=null) stack.Push(root2);
    while(stack.Any()){
        var node = stack.Pop();
        if(node.left!=null) stack.Push(node.left);
        if(node.right!=null) stack.Push(node.right);
        if(node.right==null &&node.left==null) s2.Append(node.val.ToString());
    }

    return s1.ToString()==s2.ToString();
}