import java.util.Scanner;
import java.util.Arrays;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int[] aa = new int[a];
        for(int i=0; i<a;i++){
            aa[i]=in.nextInt();
        }
        Arrays.sort(aa);
        int t=0;
        int st=0;
        for(int i=0;i<a;i++){
            t=t+aa[i];
            st+=t;
        }
        System.out.println(st);
    }
}