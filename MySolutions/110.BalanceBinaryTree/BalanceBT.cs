namespace MySolutions._110.BalanceBinaryTree
{
    internal class BalanceBT
    {
        public bool IsBalanced(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            int result = IsBinaryTree(root);

            return result != -1 ? true : false;
        }

        public int IsBinaryTree(TreeNode node)
        {
            if (node is null)
            {
                return 0;
            }

            int left = IsBinaryTree(node.left);
            int right = IsBinaryTree(node.right);

            if (left == -1 || right == -1)
            {
                return -1;
            }
            if (left == right)
            {
                return left + 1;
            }
            if (left + 1 == right)
            {
                return right + 1;
            }
            if (right + 1 == left)
            {
                return left + 1;
            }

            return -1;
        }
    }
}
