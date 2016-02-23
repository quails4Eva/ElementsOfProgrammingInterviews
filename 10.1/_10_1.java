
public class _10_1 {
    public static void main (String[] args) {
        
        BinaryTreeNode<String> tree1 = new BinaryTreeNode<String>(
            "1",
            new BinaryTreeNode<String> (
                "level 2",
                new BinaryTreeNode<String> ("Level 3", null, null),
                new BinaryTreeNode<String> ("Level 3", null, null)
            ),
            new BinaryTreeNode<String> (
                "level 2",
                new BinaryTreeNode<String> ("Level 3", null, null),
                new BinaryTreeNode<String> ("Level 3", null, null)
            )
        );
        
        System.out.println(tree1.isBalanced());
        
        BinaryTreeNode<String> tree2 = new BinaryTreeNode<String>(
            "1",
            new BinaryTreeNode<String> (
                "level 2",
                new BinaryTreeNode<String> ("Level 3", null, null),
                new BinaryTreeNode<String> ("Level 3", null, null)
            ),
            null
        );
        
        System.out.println(tree2.isBalanced());
        
        BinaryTreeNode<String> tree3 = new BinaryTreeNode<String>(
            "1",
            new BinaryTreeNode<String> (
                "level 2",
                new BinaryTreeNode<String> ("Level 3", null, null),
                new BinaryTreeNode<String> ("Level 3", null, null)
            ),
            new BinaryTreeNode<String> (
                "level 2",
                new BinaryTreeNode<String> ("Level 3", null, null),
                null
            )
        );
        
        System.out.println(tree3.isBalanced());
        
        System.out.println(tree1.height);
        tree1.setLeft(null);
        System.out.println(tree1.isBalanced());
        System.out.println(tree1.height);
        tree1.right.setRight(null);
        System.out.println(tree1.height);
        System.out.println(tree1.isBalanced());
        tree1.right.setLeft(null);
        System.out.println(tree1.height);
        System.out.println(tree1.isBalanced());
    }
}