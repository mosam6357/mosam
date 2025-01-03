import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int max = 0;
        int sum = 0;
        for (int i=0;i<a;i++){
            int q = in.nextInt();
            max = max>q?max:q;
            sum+=q;
        }
        System.out.println(sum-max);
    }
}