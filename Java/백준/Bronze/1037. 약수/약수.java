import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int N = in.nextInt();
        int max = 0;
        int min = 10000;
        while(N>0){
            int Q = in.nextInt();
            max = Q>max?Q:max;
            min = Q<min?Q:min;
            N=N-1;
        }
        System.out.println(max*min);
    }
}