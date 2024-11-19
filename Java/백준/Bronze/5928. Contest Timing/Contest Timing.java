import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int time = (in.nextInt()-11)*1440+(in.nextInt()-11)*60+in.nextInt()-11;
        System.out.println((time<0)?-1:time);
    }
}