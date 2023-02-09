namespace MySolutions._111.MinimumDepthOfBinaryTree
{
    internal class MiniDepthBTree
    {
        public int MinDepth(TreeNode root)
        {
            return DFS(root);
        }

        private int DFS(TreeNode node)
        {
            if (node == null)
                return 0;

            else if (node.left == null)
                return DFS(node.right) + 1;

            else if (node.right == null)
                return DFS(node.left) + 1;

            int leftH = DFS(node.left);
            int rightH = DFS(node.right);

            return leftH > rightH ? rightH + 1 : leftH + 1;
        }
    }
}
