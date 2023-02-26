namespace MySolutions._145.BSTPostOrder
{
    internal class BTreePostOdr
    {
        public IList<int> PostorderTraversal(TreeNode root)
        {
            IList<int> list = new List<int>(); //save the result
            Traverse(root, list);

            return list;
        }

        public void Traverse(TreeNode node, IList<int> result)
        {
            if (node is null)
                return;

            Traverse(node.left, result);
            Traverse(node.right, result);
            result.Add(node.val);
        }
    }
}
