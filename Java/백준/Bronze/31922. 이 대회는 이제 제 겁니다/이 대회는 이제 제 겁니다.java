import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int[] a = new int[3];
        for(int i=0; i<3; i++)a[i]=in.nextInt();
        System.out.println(a[0]+a[2]>a[1]?a[0]+a[2]:a[1]);
    }
}