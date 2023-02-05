namespace MySolutions._21.MergeTwoSortedList
{
    internal class MergeSortedList
    {
        public ListNode? MergeTwoLists(ListNode? list1, ListNode? list2)
        {
            List<int> values = new List<int>();
            ListNode result;

            if (list1 == null && list2 == null)
            {
                return list1;
            }

            while (list1 != null)
            {
                values.Add(list1.val);
                list1 = list1.next;
            }

            while (list2 != null)
            {
                values.Add(list2.val);
                list2 = list2.next;
            }

            values.Sort();
            result = new ListNode(values[0]);

            for (int i = 1; i < values.Count; i++)
            {
                GenerateResult(result, values[i]);
            }

            return result;
        }

        private void GenerateResult(ListNode head, int val)
        {
            ListNode newNode = new ListNode(val);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                var temp = head;

                while (temp.next != null)
                {
                    temp = temp.next;
                }

                temp.next = newNode;
                head = temp;
            }
        }
    }
}
