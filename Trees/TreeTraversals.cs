using System;
using System.Collections;

namespace Trees
{
    class TreeTraversals
    {
        public void levelOrder(Node root)
        {
            Queue q = new Queue();
            q.Enqueue(root);
            while (q.Count > 0)
            {
                Node t = (Node)q.Dequeue();
                Console.Write(t.value + " ");
                if (t.left != null)
                    q.Enqueue(t.left);
                if (t.right != null)
                    q.Enqueue(t.right);
            }
        }
    }
}
