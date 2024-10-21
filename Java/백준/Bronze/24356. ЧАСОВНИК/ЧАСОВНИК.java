import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int t1 = in.nextInt();
        int m1 = in.nextInt();
        int t2 = in.nextInt();
        int m2 = in.nextInt();
        int time = (t2-t1)*60+(m2-m1);
        time = time<0?time+1440:time;
        System.out.printf("%d %d",time,time/30);
    }
}