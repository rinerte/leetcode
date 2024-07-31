﻿// You are given the root of a binary tree.

// A ZigZag path for a binary tree is defined as follow:

// Choose any node in the binary tree and a direction (right or left).
// If the current direction is right, move to the right child of the current node; otherwise, move to the left child.
// Change the direction from right to left or from left to right.
// Repeat the second and third steps until you can't move in the tree.
// Zigzag length is defined as the number of nodes visited - 1. (A single node has a length of 0).

// Return the longest ZigZag path contained in that tree.
public int LongestZigZag(TreeNode root) {
    int left = 0;
    int right = 0;        
    if(root?.left!=null) left  =Zig(root.left,true,1);
    if(root?.right!=null) right  =Zig(root.right,false,1);
    return Math.Max(left,right);
}

int Zig(TreeNode node, bool toLeft, int currCount){
    int left = 0;
    int right = 0;

    if(toLeft){
        // have to go right
        if(node.right!=null){
            right = Zig(node.right, !toLeft, currCount+1);
        } else right = currCount;

        if(node.left!=null){
            left = Zig(node.left, toLeft, 1);
        } else left = 0;

    } else {
        // have to go left
        if(node.left!=null){
            left = Zig(node.left, !toLeft, currCount+1);
        } else left = currCount;

        if(node.right!=null){
            right = Zig(node.right, toLeft, 1);
        } else right = 0;
    }

    return Math.Max(left,right);
}