// Given the root of an n-ary tree, return the postorder traversal of its nodes' values.

// Nary-Tree input serialization is represented in their level order traversal. Each group of children is separated by the null value (See examples)
// Definition for a Node.
// public class Node {
//     public int val;
//     public IList<Node> children;

//     public Node() {}

//     public Node(int _val) {
//         val = _val;
//     }

//     public Node(int _val, IList<Node> _children) {
//         val = _val;
//         children = _children;
//     }
// }


public class Solution {
    public IList<int> Postorder(Node root) {
        IList<int> l = new List<int>();
        if(root==null) return l;
        Stack<Node> q = new();
        q.Push(root);
        while(q.Any()){
            var n = q.Pop();
            l.Add(n.val);            
            foreach(var node in n.children) q.Push(node);
        }
        
        return l.Reverse().ToArray();
    }
}