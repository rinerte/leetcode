public bool HasPathSum(TreeNode root, int targetSum)
{
    if (root == null) return false;
    int currentSum = root.val;

    if(currentSum == targetSum && root.left==null && root.right==null) return true;

    return (HasPathSum(root.left, targetSum - currentSum) || HasPathSum(root.right, targetSum - currentSum));
}