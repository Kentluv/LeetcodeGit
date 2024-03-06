public class IsSameTree_Solution {
    public bool IsSameTree(TreeNode p, TreeNode q) {
        if(p == null && q != null)
            return false;

        if(q == null && p != null)
            return false;

        if(q == null && p == null)
            return true;

        if(q!.val != p!.val)
            return false;
        
        return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
    }
}