import java.util.*;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int sum=0;
        Stack<Integer> s = new Stack<>();
        for (int i=0; i<a; i++){
            int b = in.nextInt();
            if(b==0){
                s.pop();
            }
            else{
                s.push(b);
            }
        }
        for (int x:s){
            sum+=x;
        }
        System.out.println(sum);
    }
}