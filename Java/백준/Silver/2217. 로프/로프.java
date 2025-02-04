import java.util.*;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int[] aa = new int[a];
        for (int i=0;i<a;i++){
            aa[i] = in.nextInt();
        }
        Arrays.sort(aa);
        for (int i=0;i<a;i++){
            aa[i]*=a-i;
        }
        int m = 0;
        for (int i:aa){
            m = m>i?m:i;
        }
        System.out.println(m);
    }
}