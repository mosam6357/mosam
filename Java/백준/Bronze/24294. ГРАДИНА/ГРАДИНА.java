import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int[] a = new int[4];
        for (int i =0; i<4; i++){
            a[i] = in.nextInt();
        }
        System.out.println(a[0]>a[2]?a[0]*2+(a[1]+a[3])*2+4:a[2]*2+(a[1]+a[3])*2+4);
    }
}