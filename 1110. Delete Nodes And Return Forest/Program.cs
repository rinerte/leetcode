// Given the root of a binary tree, each node in the tree has a distinct value.

// After deleting all nodes with a value in to_delete, we are left with a forest (a disjoint union of trees).

// Return the roots of the trees in the remaining forest. You may return the result in any order.
var t = new TreeNode(1,null,new TreeNode(2,null,new TreeNode(3, null, null)));
var c = DelNodes(t,new int[1]{3});

public IList<TreeNode> DelNodes(TreeNode root, int[] to_delete) {
    HashSet<int> hash = new HashSet<int>(to_delete);
    List<TreeNode> forest = new List<TreeNode>();
    F(root, hash, forest, true);
    return forest;
}

TreeNode F(TreeNode node, HashSet<int> hash, List<TreeNode> forest, bool isRoot) {
    if (node == null) {
        return null;
    }

    bool toDelete = hash.Contains(node.val);

    if (isRoot && !toDelete) {
        forest.Add(node);
    }

    node.left = F(node.left, hash, forest, toDelete);
    node.right = F(node.right, hash, forest, toDelete);

    return toDelete ? null : node;
}

class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}