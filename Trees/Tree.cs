namespace Trees
{
    public class Node
    {
        public int value;
        public Node right;
        public Node left;
    }
    public class BST
    {
        public Node Search(Node n, int key)
        {
            if (n == null)
                return null;
            if (key == n.value)
                return n;
            if (key < n.value)
            {
                return (Search(n.left, key));
            }
            else
            {
                return (Search(n.right, key));
            }
        }
        public Node InsertNode(Node root, int value)
        {
            if (root == null)
            {
                Node n = new Node();
                n.left = null;
                n.right = null;
                n.value = value;
                root = n;
                return root;
            }
            Node head = new Node();
            head = root;

            if (value <= root.value)
            {
                if (root.left == null)
                {
                    Node n = new Node();
                    n.value = value;
                    n.left = null;
                    n.right = null;
                    root.left = n;
                    return head;
                }
                else
                    InsertNode(root.left, value);
            }
            else if (value > root.value)
            {
                if (root.right == null)
                {
                    Node n = new Node();
                    n.value = value;
                    n.left = null;
                    n.right = null;
                    root.right = n;
                    return head;
                }
                else
                    InsertNode(root.right, value);
            }
            return root;
        }
    }
}
