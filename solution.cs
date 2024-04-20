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
}