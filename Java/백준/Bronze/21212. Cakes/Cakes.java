import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int min = 10000;
        for (int i=0;i<a;i++){
            int n = in.nextInt();
            int m = in.nextInt();
            int x = m/n;
            min = min<x?min:x;
        }
        System.out.println(min);
    }
}