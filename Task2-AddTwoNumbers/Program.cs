namespace Task2_AddTwoNumbers
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
    public static class Solution
    {
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int num1 = 0;
            int num2 = 0;
            ListNode l3 = new ListNode();
            int addition = 0;
            int sum = 0;
            ListNode current = new ListNode();

            while (true)
            {
                if (l1.next != null)
                {
                    num1 = l1.val;
                }
                else if ((l1.next == null) && (l1.val != 0))
                {
                    num1 = l1.val;
                    l1 = new ListNode();
                }
                else
                {
                    num1 = 0;
                }

                if (l2.next != null)
                {
                    num2 = l2.val;
                }
                else if ((l2.next == null) && (l2.val != 0))
                {
                    num2 = l2.val;
                    l2 = new ListNode();
                }
                else
                {
                    num2 = 0;
                }

                sum = num1 + num2 + addition;

                if (sum >= 10)
                {
                    addition = 1;
                    sum = sum % 10;
                }
                else
                {
                    addition = 0;
                }

                if (l3.next == null)
                {
                    l3.val = sum;

                    if (l1.next != null || l2.next != null || addition != 0)
                    {
                        l3.next = new ListNode();
                        current = l3.next;
                    }
                }
                else
                {
                    current.val = sum;
                    if (l1.next != null || l2.next != null || addition != 0)
                    {
                        current.next = new ListNode();
                        current = current.next;
                    }
                }

                if (l1.next == null && l2.next == null && addition == 0)
                {
                    break;
                }

                if (l1.next != null)
                {
                    l1 = l1.next;
                }

                if (l2.next != null)
                {
                    l2 = l2.next;
                }
            }
            return l3;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            ListNode l1 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9)))));
            ListNode l2 = new ListNode(9, new ListNode(9));

            ListNode l3 = Solution.AddTwoNumbers(l1, l2);

            Console.ReadKey();
        }
    }
}
