import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int time = 0;
        for (int i=0; i<4; i++){
            time+=in.nextInt();
        }
        System.out.printf("%d\n%d",time/60,time%60);
    }
}