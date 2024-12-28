import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        long a = in.nextInt();
        long b = in.nextInt();
        long[] s = {0,b-1,a-1,a-1,(a-1)*(b-2)};
        long sum = 0;
        for (int i=0; i<5; i++){
            sum+=i*s[i];
        }
        System.out.println(sum);
    }
}