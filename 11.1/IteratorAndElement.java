import java.util.Iterator;

public class IteratorAndElement<T extends Comparable<T>> implements Comparable<IteratorAndElement<T>> {
    
    public T element;
    public Iterator<T> iterator;
    
    public IteratorAndElement(T element, Iterator<T> iterator) {
        
        this.element = element;
        this.iterator = iterator;
    }
    
    public int compareTo(IteratorAndElement<T> iterAndElem) {
        // Could probably do with some null checking
        return this.element.compareTo(iterAndElem.element);
    }
}