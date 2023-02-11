namespace MySolutions._112.PathSum
{
    internal class SumBTPath
    {
        public bool HasPathSum(TreeNode root, int targetSum)
        {
            if (root is null)
                return false;

            if (root.left == null && root.right == null)
                return root.val == targetSum;

            return HasPathSum(root.left, targetSum - root.val) ||
                   HasPathSum(root.right, targetSum - root.val);
        }
    }
}
