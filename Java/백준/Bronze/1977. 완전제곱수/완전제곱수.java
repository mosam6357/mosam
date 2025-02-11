import java.util.Scanner;
import java.lang.Math;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int b = in.nextInt();
        int sum = 0;
        int min = 0;
        for (int i=a;i<=b;i++){
            if (Math.pow(i,0.5)%1==0){
                sum += i;
                if (min==0){
                    min = i;
                }
            }
        }
        if (sum==0){
            System.out.println(-1);
        }
        else{
            System.out.println(sum);
            System.out.println(min);
        }
    }
}