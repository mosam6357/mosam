import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a=in.nextInt();int b = in.nextInt();int c = in.nextInt();
        int f1 = b*2+c*4;
        int f2 = a*2+c*2;
        int f3 = a*4+b*2;
        int min = f1<f2?f1:f2;
        min = min<f3?min:f3;
        System.out.println(min);
    }
}