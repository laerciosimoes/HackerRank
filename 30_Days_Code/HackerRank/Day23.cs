using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public class Node23
    {
        public Node23 left, right;
        public int data;
        public Node23(int data)
        {
            this.data = data;
            left = right = null;
        }
    }

    public class Day23
    {
        private static Queue<Node23> qResult = new Queue<Node23>();
        private static List<int> lstResult = new List<int>();

        static void levelOrder(Node23 root)
        {
            //Write your code here
            getItems(root);

            Console.WriteLine(String.Join(" ", lstResult.ToArray()));
        }

        static void getItems(Node23 node)
        {
            lstResult.Add(node.data);

            if (node.left != null)
            {
                qResult.Enqueue(node.left);
            }

            if (node.right != null)
            {
                qResult.Enqueue(node.right);
            }



            while (qResult.Count() > 0)
            {
                getItems(qResult.Dequeue());
            }
        }

        private static Node23 insert(Node23 root, int data)
        {
            if (root == null)
            {
                return new Node23(data);
            }
            else
            {
                Node23 cur;
                if (data <= root.data)
                {
                    cur = insert(root.left, data);
                    root.left = cur;
                }
                else
                {
                    cur = insert(root.right, data);
                    root.right = cur;
                }
                return root;
            }
        }

        public static void Main(String[] args)
        {
            Node23 root = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                root = insert(root, data);
            }
            levelOrder(root);

        }
    }
}
