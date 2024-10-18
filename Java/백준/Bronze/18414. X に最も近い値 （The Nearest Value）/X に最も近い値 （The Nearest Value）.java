import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int[] a = new int[3];
        for (int i = 0; i<3; i++){
            a[i] = in.nextInt();
        }
        int min = Math.min(Math.min(a[0],a[1]),a[2]);
        int max = Math.max(Math.max(a[0],a[1]),a[2]);
        System.out.println(a[0]+a[1]+a[2]-min-max);
    }
}