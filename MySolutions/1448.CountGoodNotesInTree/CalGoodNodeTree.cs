namespace MySolutions._1448.CountGoodNotesInTree
{
    internal class CalGoodNodeTree
    {
        public int GoodNodes(TreeNode root)
        {
            return numberOfGoodNodes(root, root.val);
        }

        public int numberOfGoodNodes(TreeNode root, int min)
        {
            //base
            if (root is null)
            {
                return 0;
            }

            int max = root.val >= min ? root.val : min;

            int goodNode = 0;
            if (root.val >= min)
            {
                goodNode += 1;
            }

            return numberOfGoodNodes(root.left, max) + numberOfGoodNodes(root.right, max) + goodNode;
        }
    }
}
