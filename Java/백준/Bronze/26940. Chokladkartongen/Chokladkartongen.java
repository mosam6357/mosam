import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int p = in.nextInt();
        int cnt = 0;
        for (int i=0;i<a-1;i++){
            int q = in.nextInt();
            if (q>p){
                cnt++;
            }
            p = q;
        }
        System.out.println(cnt);
    }
}