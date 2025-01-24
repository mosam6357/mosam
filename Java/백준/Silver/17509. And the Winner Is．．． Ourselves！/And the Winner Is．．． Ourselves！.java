import java.util.Scanner;
import java.util.Arrays;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int p = 0;
        int time = 0;
        int[] aa = new int[11];
        for (int i=0;i<11;i++){
            aa[i] = in.nextInt();
            p+=20*in.nextInt();
        }
        Arrays.sort(aa);
        for (int i=0;i<11;i++){
            time += aa[i];
            p+=time;
        }
        System.out.println(p);
    }
}