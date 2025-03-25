import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int[] aa = new int[a];
        int total = 0;
        for (int i=0;i<a;i++){
            aa[i] = in.nextInt();
            if (i==0 || aa[i]!=aa[i-1]+1){
                total += aa[i];
            }
        }
        System.out.println(total);
    }
}