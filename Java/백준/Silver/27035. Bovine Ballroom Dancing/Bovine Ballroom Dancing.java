import java.util.*;
import java.lang.Math;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int[] aa = new int[a];
        int[] bb = new int[a];
        for (int i=0;i<a;i++){
            aa[i] = in.nextInt();
        }
        for (int i=0;i<a;i++){
            bb[i]= in.nextInt();
        }
        int sum = 0;
        Arrays.sort(aa);
        Arrays.sort(bb);
        for (int i=0;i<a;i++){
            sum+=Math.abs(aa[i]-bb[i]);
        }
        System.out.println(sum);
    }
}