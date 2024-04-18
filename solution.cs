Here is a C# console application that finds all root-to-leaf paths in a binary tree:

```C#
using System;
using System.Collections.Generic;

public class Node
{
    public int data;
    public Node left, right;
    public Node(int item)
    {
        data = item;
        left = right = null;
    }
}

public class BinaryTree
{
    Node root;

    void printPaths(Node node, List<int> path)
    {
        if (node == null)
            return;

        path.Add(node.data);

        if (node.left == null && node.right == null)
        {
            Console.WriteLine(string.Join("->", path));
        }
        else
        {
            printPaths(node.left, new List<int>(path));
            printPaths(node.right, new List<int>(path));
        }
    }

    void printAllPaths()
    {
        printPaths(root, new List<int>());
    }

    public static void Main(String[] args)
    {
        BinaryTree tree = new BinaryTree();
        tree.root = new Node(1);
        tree.root.left = new Node(2);
        tree.root.right = new Node(3);
        tree.root.left.left = new Node(4);
        tree.root.left.right = new Node(5);

        tree.printAllPaths();
    }
}
```

This program creates a binary tree and then prints all root-to-leaf paths. The `printPaths` method is used to print all root-to-leaf paths. It takes a node and a list of integers (representing the current path) as arguments. If the node is null, it returns. If the node is a leaf node (both left and right children are null), it prints the current path. Otherwise, it recursively calls itself for the left and right children of the node, passing a new list that includes the current path. The `printAllPaths` method is a helper method that calls `printPaths` with the root of the tree and an empty list.