using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public class Node24
    {
        public int data;
        public Node24 next;
        public Node24(int d)
        {
            data = d;
            next = null;
        }

    }
   public  class Day24
    {
        private static List<int> lstNumbers = new List<int>();

        public static Node24 removeDuplicates(Node24 head)
        {
            //Write your code here
            lstNumbers.Add(head.data);
            checkDuplicate(head, head.next);
            return head;
        }

        public static void checkDuplicate(Node24 prior, Node24 node)
        {
            if (node == null) return;
            if (lstNumbers.Contains(node.data))
            {
                prior.next = node.next;
                checkDuplicate(prior, prior.next);
            }
            else
            {
                lstNumbers.Add(node.data);
                checkDuplicate(node, node.next);
            }
        }

        public static Node24 insert(Node24 head, int data)
        {
            Node24 p = new Node24(data);


            if (head == null)
                head = p;
            else if (head.next == null)
                head.next = p;
            else
            {
                Node24 start = head;
                while (start.next != null)
                    start = start.next;
                start.next = p;

            }
            return head;
        }
        public static void display(Node24 head)
        {
            Node24 start = head;
            while (start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }

        public static void Main(String[] args)
        {

            Node24 head = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                head = insert(head, data);
            }
            head = removeDuplicates(head);
            display(head);
        }
    }
}
