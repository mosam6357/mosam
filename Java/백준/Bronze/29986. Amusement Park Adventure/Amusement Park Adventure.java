import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int cm = in.nextInt();
        int cnt = 0;
        for (int i=0;i<a;i++){if(in.nextInt()<=cm)cnt++;}
        System.out.println(cnt);
    }
}