using System;

namespace Trees
{    
    class Testing
    {
        static void Main(string[] args)
        {                        
            int[] arr = new int[8] { 5, 4, 9, 3, 10, 0, -1, 9 };
            BST bst = new BST();
            Node head = new Node();
            head = null;

            for (int i = 0; i < arr.Length; i++)
            {
                head = bst.InsertNode(head, arr[i]);
            }
            TreeTraversals traverse = new TreeTraversals();

            traverse.levelOrder(head);
            Console.WriteLine();
        }
    }
}