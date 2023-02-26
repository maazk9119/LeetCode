namespace MySolutions._101.SymmetricTree
{
    internal class SymTree
    {
        public bool IsSymmetric(TreeNode root)
        {
            if (root is null)
            {
                return true;
            }

            return Validate(root.left, root.right);
        }

        public bool Validate(TreeNode node1, TreeNode node2)
        {
            if (node1 is null && node2 is null)
            {
                return true;
            }

            if (node1 is null && node2 is not null ||
               node1 is not null && node2 is null ||
               (node1 is not null && node2 is not null &&
                node1.val != node2.val))
            {
                return false;
            }

            return Validate(node1.left, node2.right) && Validate(node1.right, node2.left);
        }
    }
}
