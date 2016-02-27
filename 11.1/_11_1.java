import java.util.List;
import java.util.LinkedList;

public class _11_1 {
    public static void main (String[] args) {
        
        List<Integer> list1 = new LinkedList<Integer>();
        list1.add(0);
        list1.add(0);
        list1.add(1);
        list1.add(4);
        list1.add(5);
        list1.add(9);
        
        List<Integer> list2 = new LinkedList<Integer>();
        list2.add(0);
        list2.add(1);
        list2.add(4);
        list2.add(6);
        list2.add(20);
        list2.add(25);
        
        List<Integer> list3 = new LinkedList<Integer>();
        list3.add(8);
        
        List<Integer> list4 = new LinkedList<Integer>();
        list4.add(2);
        list4.add(4);
        list4.add(6);
        list4.add(8);
        list4.add(10);
        list4.add(12);
        
        
        List<List<Integer>> fullList = new LinkedList<List<Integer>>();
        fullList.add(list1);
        fullList.add(list2);
        fullList.add(list3);
        fullList.add(list4);
        
        List<Integer> resultList = new SetOfListsJoiner<Integer>((List<List<Integer>>)fullList).join();
        
        for (Integer result : resultList) {
            System.out.println(result);
        }
    }
}