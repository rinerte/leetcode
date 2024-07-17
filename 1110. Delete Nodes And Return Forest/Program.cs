// Given the root of a binary tree, each node in the tree has a distinct value.

// After deleting all nodes with a value in to_delete, we are left with a forest (a disjoint union of trees).

// Return the roots of the trees in the remaining forest. You may return the result in any order.
var t = new TreeNode(1,null,new TreeNode(2,null,new TreeNode(3, null, null)));
var c = DelNodes(t,new int[1]{3});

IList<TreeNode> DelNodes(TreeNode root, int[] to_delete) {
        
    Stack<TreeNode> stack = new();
    List<TreeNode> forest = new();
    HashSet<int> hash = new();

    foreach(int i in to_delete) hash.Add(i);   

    stack.Push(root);
    if(!hash.Contains(root.val)) forest.Add(root);
    while(stack.Any()){
        var node = stack.Pop();
        if(node==null) continue;
        
        if(hash.Contains(node.val)){
            if(node.left!=null&&!hash.Contains(node.left.val)) forest.Add(node.left);
            if(node.right!=null&&!hash.Contains(node.right.val)) forest.Add(node.right);
        }

        if(node.left!=null){
            if(hash.Contains(node.left.val)){
                TreeNode t = new(node.left.val,node.left.left,node.left.right);
                stack.Push(t);
                node.left = null;
            } else
            stack.Push(node.left);
        }
        if(node.right!=null){
            if(hash.Contains(node.right.val)){
                TreeNode t = new(node.right.val,node.right.left,node.right.right);
                stack.Push(t);
                node.right = null;
            } else
            stack.Push(node.left);
        }
    }

    return forest.ToArray();
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