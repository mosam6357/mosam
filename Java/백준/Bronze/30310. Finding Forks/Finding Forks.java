import java.util.Scanner;
import java.util.Arrays;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int[] aa = new int[a];
        for (int i=0;i<a;i++){
            aa[i] = in.nextInt();
        }
        Arrays.sort(aa);
        System.out.println(aa[0]+aa[1]);
    }
}