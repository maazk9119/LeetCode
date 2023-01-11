namespace MySolutions._100.SameTree
{
    public class TreeNode
    {
       public int val;
       public TreeNode left;
       public TreeNode right;
       
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    internal class BSTTree
    {
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            return Validate(p, q);
        }

        private bool Validate(TreeNode p, TreeNode q)
        {
            if (p == null && q != null) return false;
            if (p != null && q == null) return false;
            if (p == null && q == null) return true;

            if (p.val != q.val) return false;

            return Validate(p.left, q.left) && Validate(p.right, q.right);
        }
    }
}
