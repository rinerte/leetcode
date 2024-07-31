// Given the root of a binary tree, the level of its root is 1, the level of its children is 2, and so on.

// Return the smallest level x such that the sum of all the values of nodes at level x is maximal.
public int MaxLevelSum(TreeNode root) {
    int max = int.MinValue;
    int current =0;
    int minLevel=0;
    Queue<(TreeNode node, int level)> queue = new();
    if(root!=null) queue.Enqueue((root,0));

    while(queue.Any()){
        var t = queue.Dequeue();
        if(!queue.Any() || queue.Peek().level>t.level){
            current+=t.node.val;
            if(current>max){
                minLevel = t.level+1;
                max = current;
            }
            current = 0;
        } else current+=t.node.val;
        if(t.node.left!=null) queue.Enqueue((t.node.left,t.level+1));
        if(t.node.right!=null) queue.Enqueue((t.node.right,t.level+1));
    }
    return minLevel;
}