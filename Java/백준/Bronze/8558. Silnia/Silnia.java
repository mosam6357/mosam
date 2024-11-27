import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int[] aa = {1,1,2,6,4};
        System.out.printf("%d",(a<5)?aa[a]:0);
    }
}