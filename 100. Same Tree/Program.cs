public bool IsSameTree(TreeNode p, TreeNode q) {
    if (p?.val != q?.val || (q==null && p!=null) || (q!=null && p==null)) return false;
    if (p == null && q == null) return true;
    if(!IsSameTree(p.left, q.left)) return false;
    if (!IsSameTree(p.right, q.right)) return false ;
    return true;
}