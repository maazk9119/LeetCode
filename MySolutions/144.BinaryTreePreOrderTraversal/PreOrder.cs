namespace MySolutions._144.BinaryTreePreOrderTraversal
{
    public class TreeNode
    {
       public int val;
       public TreeNode? left;
       public TreeNode? right;
       public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
       {
            this.val = val;
            this.left = left;
            this.right = right;
       }
    }

    internal class PreOrder
    {
        public IList<int> PreorderTraversal(TreeNode root)
        {
            IList<int> result = new List<int>();
            preOrderTraversal(root, result);

            return result;
        }

        public void preOrderTraversal(TreeNode? root, IList<int> result)
        {
            if (root == null) return;

            result.Add(root.val);
            preOrderTraversal(root.left, result);
            preOrderTraversal(root.right, result);
        }
    }
}
