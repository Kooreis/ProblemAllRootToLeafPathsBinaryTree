Here is a Java console application that solves the problem:

```java
import java.util.ArrayList;
import java.util.List;

public class Main {
    public static void main(String[] args) {
        Node root = new Node(1);
        root.left = new Node(2);
        root.right = new Node(3);
        root.left.left = new Node(4);
        root.left.right = new Node(5);
        root.right.left = new Node(6);
        root.right.right = new Node(7);

        List<List<Integer>> paths = findPaths(root);
        for (List<Integer> path : paths) {
            for (int val : path) {
                System.out.print(val + " ");
            }
            System.out.println();
        }
    }

    public static List<List<Integer>> findPaths(Node root) {
        List<List<Integer>> paths = new ArrayList<>();
        findPaths(root, new ArrayList<>(), paths);
        return paths;
    }

    private static void findPaths(Node node, List<Integer> current, List<List<Integer>> paths) {
        if (node == null) {
            return;
        }

        current.add(node.val);

        if (node.left == null && node.right == null) {
            paths.add(new ArrayList<>(current));
        } else {
            findPaths(node.left, current, paths);
            findPaths(node.right, current, paths);
        }

        current.remove(current.size() - 1);
    }
}

class Node {
    int val;
    Node left;
    Node right;

    Node(int val) {
        this.val = val;
        left = null;
        right = null;
    }
}
```

This program creates a binary tree with the root node having a value of 1. The left child of the root node has a value of 2 and the right child has a value of 3. The left child of the node with value 2 has a value of 4 and the right child has a value of 5. The left child of the node with value 3 has a value of 6 and the right child has a value of 7.

The program then finds all root-to-leaf paths in the binary tree and prints them to the console.