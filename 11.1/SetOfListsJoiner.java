import java.util.PriorityQueue;
import java.util.List;
import java.util.LinkedList;
import java.util.Iterator;

public class SetOfListsJoiner<T extends Comparable<T>> {

    private List<List<T>> lists;

    // Could probably take iterators rather than lists
    public SetOfListsJoiner(List<List<T>> lists) {
        
        this.lists = lists;
    }
    
    public List<T> join() {
        
        List<T> results = new LinkedList<T>();
        
        PriorityQueue<IteratorAndElement<T>> currentMins = new PriorityQueue<IteratorAndElement<T>>(lists.size());
        
        
        for (List<T> list : this.lists) {
            
            Iterator<T> iterator = list.iterator();
            
            if (iterator.hasNext()) {
                
                currentMins.add(new IteratorAndElement<T>(iterator.next(), iterator));
            }
        }
        
        while (currentMins.peek() != null) {
        
            IteratorAndElement<T> nextElement = currentMins.poll();
            
            results.add(nextElement.element);
            
            if (nextElement.iterator.hasNext()) {
            
                currentMins.add(new IteratorAndElement<T>(nextElement.iterator.next(), nextElement.iterator));
            }
        }
        
        return results;
    }
}