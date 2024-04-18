Here is a Python console application that finds all root-to-leaf paths in a binary tree:

```python
class Node:
    def __init__(self, key):
        self.data = key
        self.left = None
        self.right = None

def printPaths(root):
    path = []
    printPathsRec(root, path, 0)

def printPathsRec(root, path, pathLen):
    if root is None:
        return

    if(len(path) > pathLen):
        path[pathLen] = root.data
    else:
        path.append(root.data)

    pathLen = pathLen + 1

    if root.left is None and root.right is None:
        printArray(path, pathLen)
    else:
        printPathsRec(root.left, path, pathLen)
        printPathsRec(root.right, path, pathLen)

def printArray(ints, len):
    for i in ints[0 : len]:
        print(i," ",end="")
    print()

root = Node(1)
root.left = Node(2)
root.right = Node(3)
root.left.left = Node(4)
root.left.right = Node(5)

print("Leaf paths are")
printPaths(root)
```

This Python console application creates a binary tree and then prints all root-to-leaf paths. The `printPaths` function is the main function that prints all paths. It uses `printPathsRec` function to print all paths. The `printPathsRec` function recursively prints all paths. If a leaf node is reached, it prints the path. The `printArray` function is used to print the path.