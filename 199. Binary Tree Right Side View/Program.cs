// Given the root of a binary tree, imagine yourself standing on the right side of it, return the values of the nodes you can see ordered from top to bottom.

public IList<int> RightSideView(TreeNode root) {
    List<int> list = new();
    Queue<(TreeNode n, int p)> queue = new();
    if(root!=null) queue.Enqueue((root,0));
    while(queue.Any()){
        var t = queue.Dequeue();
        if(!queue.Any() || queue.Peek().p>t.p ){
            list.Add(t.n.val);
        }
        if(t.n.left!=null) queue.Enqueue((t.n.left,t.p+1));
        if(t.n.right!=null) queue.Enqueue((t.n.right,t.p+1));
    }
    return list;
}