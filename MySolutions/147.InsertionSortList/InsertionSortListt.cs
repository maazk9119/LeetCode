namespace MySolutions._147.InsertionSortList
{
    public class ListNode
    {
         public int val;
         public ListNode next;
         public ListNode(int val = 0, ListNode next = null)
         {
             this.val = val;
             this.next = next;
         }
    }

    internal class InsertionSortListt
    {
        public ListNode InsertionSortList(ListNode head)
        {
            List<int> array = new List<int>();

            while (head != null)
            {
                array.Add(head.val);
                head = head.next;
            }

            if (array.Count == 1)
            {
                return new ListNode(array[0]);
            }

            //sort using insertion sort
            InsertionSort(array);

            //generate linkedList
            ListNode result = new ListNode(array[0]);
            GenerateLinkedList(result, array);

            return result;
        }

        private void InsertionSort(List<int> arr)
        {
            for (int i = 1; i < arr.Count; i++)
            {
                int j = i - 1;
                int key = arr[i];

                while (j >= 0 && key < arr[j])
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                arr[j + 1] = key;
            }
        }

        private void GenerateLinkedList(ListNode head, List<int> arr)
        {
            ListNode node;

            for (int i = 1; i < arr.Count; i++)
            {
                node = new ListNode(arr[i]);
                head.next = node;
                head = head.next;
            }

            return;
        }
    }
}
