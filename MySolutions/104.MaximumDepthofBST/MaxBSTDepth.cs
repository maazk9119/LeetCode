namespace MySolutions._104.MaximumDepthofBST
{
    internal class MaxBSTDepth
    {
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            return CalculateDepth(root);
        }

        private int CalculateDepth(TreeNode root)
        {
            if (root == null) return 0;

            int left = CalculateDepth(root.left);
            int right = CalculateDepth(root.right);

            return left > right ? left + 1 : right + 1;
        }
    }
}
