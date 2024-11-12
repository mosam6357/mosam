import java.util.*;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int[] a = new int[3];
        for(int i=0;i<3;i++){
            a[i] = in.nextInt();
        }
        Arrays.sort(a);
        System.out.println(a[1]);
    }
}