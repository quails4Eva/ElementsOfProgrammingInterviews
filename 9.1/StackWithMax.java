import java.util.Stack;

public class StackWithMax<T extends Comparable<T>> {
    
    private Stack<T> data;
    private Stack<T> currentMax;
    
    public StackWithMax() {
        
        this.data = new Stack<T>();
        this.currentMax = new Stack<T>();
    }
    
    public T push(T item) {
    
        this.data.push(item);
        
        if (this.currentMax.empty() || item.compareTo(this.currentMax.peek()) > 0) {
        
            this.currentMax.push(item);
        }
        
        return item;
    }
    
    public T pop() {
        
        T item = this.data.pop();
        
        if (!this.currentMax.empty() && item.compareTo(this.currentMax.peek()) == 0) {
            
            this.currentMax.pop();
        }
        
        return item;
    }
    
    public T max() {
        
        return this.currentMax.isEmpty() ?  : this.currentMax.peek();
    }
    
    public Boolean empty() {
        
        return this.data.empty();
    }
}