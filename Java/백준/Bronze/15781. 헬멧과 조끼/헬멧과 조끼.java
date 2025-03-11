import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int b = in.nextInt();
        int max1 = 0;
        int max2 = 0;
        for (int i=0;i<a;i++){
            int n = in.nextInt();
            max1 = n>max1?n:max1;
        }
        for (int i=0;i<b;i++){
            int n = in.nextInt();
            max2 = n>max2?n:max2;
        }
        System.out.println(max1+max2);
    }
}