// Given a binary tree root, a node X in the tree is named good if in the path from root to X there are no nodes with a value greater than X.

// Return the number of good nodes in the binary tree.
int count =0;
public int GoodNodes(TreeNode root) {
    Check(root,root.val);
    return count;
}

void Check(TreeNode node, int maxValue){
    if(node.val>=maxValue) count++;
    if(node.left!=null) Check(node.left, node.val>maxValue?node.val:maxValue);
    if(node.right!=null) Check(node.right, node.val>maxValue?node.val:maxValue);
}