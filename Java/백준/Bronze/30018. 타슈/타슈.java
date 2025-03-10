import java.util.Scanner;
import java.lang.Math;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int[] aa = new int[a];
        for (int i=0;i<a;i++){
            aa[i]=in.nextInt();
        }
        int[] bb = new int[a];
        for (int i=0;i<a;i++){
            bb[i]=in.nextInt();
        }
        int total = 0;
        for (int i=0;i<a;i++){
            total+= Math.abs(aa[i]-bb[i]);
        }
        System.out.println(total/2);
    }
}