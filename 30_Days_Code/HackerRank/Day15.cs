using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public class Node
    {
        public int data;
        public Node next;
        public Node(int d)
        {
            data = d;
            next = null;
        }

    }

    public class Day15
    {
        public static Node insert(Node head, int data)
        {
            if (head == null)
            {
                head = new Node(data);
            }
            else
            {
                if(head.next == null)
                {
                    head.next = new Node(data);
                } else
                {
                    var node = head.next;
                    while (true)
                    {
                        if(node.next == null)
                        {
                            node.next = new Node(data);
                            break;
                        } else
                        {
                            node = node.next;
                        }
                    }
                    node.next = new Node(data);
                }
            }
            return head;
        }

        public static void display(Node head)
        {
            Node start = head;
            while (start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }

        public static void Main(String[] args)
        {
            Node head = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                head = insert(head, data);
            }
            display(head);
        }
    }
}
