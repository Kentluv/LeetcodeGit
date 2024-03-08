
public class ConnectII_Solution {
    public Node Connect(Node root) {
        if(root == null) return null!;
        if(root.left != null)
        {
            if(root.right != null)
            {
                root.left.next = root.right;
            }
            else
            {
                root.left.next = GetNext(root.next);
            }
        }
        if(root.right != null)
        {
            root.right.next = GetNext(root.next);
        }
        Connect(root.right!);
        Connect(root.left!);
        return root;
    }

    private Node? GetNext(Node? next)
    {
        while(next != null)
        {
            if(next.left != null) return next.left;
            if(next.right != null) return next.right;
            next = next.next;
        }
        return null;
    }
}