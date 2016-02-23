public class BinaryTreeNode<T> {
    
    public BinaryTreeNode() {
        
    }
    
    public BinaryTreeNode(T data, BinaryTreeNode<T> left, BinaryTreeNode<T> right) {
        
        this.data = data;
        setLeft(left);
        setRight(right);
    }
    
    public int height = 0;
    
    public T data;
    
    public BinaryTreeNode<T> left;
    public BinaryTreeNode<T> right;
    
    public BinaryTreeNode<T> parent;
    
    public void setLeft(BinaryTreeNode<T> left){
                
        this.left = left;
        
        if (left != null) {
            left.parent = this;
        }
        
        this.recheckHeight();
    }
    
    public void setRight(BinaryTreeNode<T> right){
        
        this.right = right;
        
        if (right != null) {
            right.parent = this;
        }
        
        this.recheckHeight();
    }
    
    private void setHeight(int newHeight) {
        
        if (newHeight != this.height) {
        
            this.height = newHeight;
            
            if (this.parent != null) {
                
                this.parent.recheckHeight();
            }
        }
    }
    
    private void recheckHeight() {
        
        this.setHeight(Math.max(getHeight(this.left), getHeight(this.right)) + 1);
    }
    
    public boolean isBalanced() {
        return (left == null || left.isBalanced()) && (right == null || right.isBalanced()) && (Math.abs(getHeight(this.left) - getHeight(this.right)) <= 1);
    }
    
    private static int getHeight(BinaryTreeNode node) {
        
        return node == null ? -1 : node.height;
    }
}