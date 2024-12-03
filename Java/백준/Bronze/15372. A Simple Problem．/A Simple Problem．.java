import java.util.*;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        for(int i=0; i<a; i++){
            long b = in.nextLong();
            System.out.println(b*b);
        }
    }
}