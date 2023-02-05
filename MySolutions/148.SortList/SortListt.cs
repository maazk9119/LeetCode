namespace MySolutions._148.SortList
{
    internal class SortListt
    {
        public ListNode SortList(ListNode head)
        {
            if (head == null)
            {
                return null;
            }

            List<int> values = new List<int>();

            while (head != null)
            {
                values.Add(head.val);
                head = head.next;
            }

            values.Sort();
            ListNode result = new ListNode(values[0]);
            AddNode(result, values);

            return result;
        }

        private void AddNode(ListNode head, List<int> values)
        {
            ListNode node;

            for (int i = 1; i < values.Count; i++)
            {
                node = new ListNode(values[i]);
                head.next = node;
                head = head.next;
            }
        }
    }
}
