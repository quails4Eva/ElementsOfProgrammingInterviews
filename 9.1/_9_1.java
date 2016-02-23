public class _9_1 {
    public static void main(String[] args) {
        
        StackWithMax<Integer> blarh = new StackWithMax<Integer>();
        
        blarh.push(1);
        System.out.println(blarh.max());
        
        blarh.push(1);
        System.out.println(blarh.max());
        
        blarh.push(0);
        System.out.println(blarh.max());
        
        blarh.push(3);
        System.out.println(blarh.max());
        
        blarh.push(2);
        System.out.println(blarh.max());
        
        blarh.pop();
        System.out.println(blarh.max());
        
        blarh.pop();
        System.out.println(blarh.max());
        
        blarh.pop();
        System.out.println(blarh.max());
        
        blarh.pop();
        System.out.println(blarh.max());
        
        blarh.pop();
        System.out.println(blarh.max());
    }
}