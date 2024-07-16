// You are given the root of a binary tree with n nodes. Each node is uniquely assigned a value from 1 to n. You are also given an integer startValue representing the value of the start node s, and a different integer destValue representing the value of the destination node t.

// Find the shortest path starting from node s and ending at node t. Generate step-by-step directions of such path as a string consisting of only the uppercase letters 'L', 'R', and 'U'. Each letter indicates a specific direction:

// 'L' means to go from a node to its left child node.
// 'R' means to go from a node to its right child node.
// 'U' means to go from a node to its parent node.
// Return the step-by-step directions of the shortest path from node s to node t.
public string GetDirections(TreeNode root, int startValue, int destValue) {
    StringBuilder first = new();
    StringBuilder second = new();
    Stack<TreeNode> stack = new();
    Dictionary<int,bool> visited = new();
    stack.Push(root);

    while(stack.Count()>0){
        var node = stack.Peek();
        if(node.val==startValue){
            stack = new();
            visited = new();
            break;
        }
        if(visited.ContainsKey(node.val)){
            first.Length--;
            stack.Pop();
        }
        if(node.left!=null){
            first.Append("L");
            stack.Push(node.left);
        }
        if(node.right!=null){
            first.Append("R");
            stack.Push(node.right);
        }
        if(node.left==null && node.right==null){
            first.Length--;
            stack.Pop();
        }
        
        visited[node.val] = true;
    }
    //second
    stack.Push(root);

    while(stack.Count()>0){
        var node = stack.Peek();
        if(node.val==destValue){
            break;
        }
        if(visited.ContainsKey(node.val)){
            second.Length--;
            stack.Pop();
        }
        if(node.left!=null){
            second.Append("L");
            stack.Push(node.left);
        }
        if(node.right!=null){
            second.Append("R");
            stack.Push(node.right);
        }
        if(node.left==null && node.right==null){
            second.Length--;
            stack.Pop();
        }
        
        visited[node.val] = true;
    }

    return first.ToString()+"+"+second.ToString();

}