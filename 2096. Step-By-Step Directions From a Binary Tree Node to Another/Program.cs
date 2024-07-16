// You are given the root of a binary tree with n nodes. Each node is uniquely assigned a value from 1 to n. You are also given an integer startValue representing the value of the start node s, and a different integer destValue representing the value of the destination node t.

// Find the shortest path starting from node s and ending at node t. Generate step-by-step directions of such path as a string consisting of only the uppercase letters 'L', 'R', and 'U'. Each letter indicates a specific direction:

// 'L' means to go from a node to its left child node.
// 'R' means to go from a node to its right child node.
// 'U' means to go from a node to its parent node.
// Return the step-by-step directions of the shortest path from node s to node t.
public string GetDirections(TreeNode root, int startValue, int destValue) {
    Dictionary<int,string> paths= new();
        Stack<TreeNode> stack = new();
        stack.Push(root);
        paths[root.val] = "";

        while(stack.Any()){
            var node = stack.Pop();
            if(node.left!=null){
                paths[node.left.val] = paths[node.val]+"L";
                stack.Push(node.left);
            }
            if(node.right!=null){
                paths[node.right.val] = paths[node.val]+"R";
                stack.Push(node.right);
            }
        }
        result = paths[startValue] + paths[destValue];
        return result.ToString();

}