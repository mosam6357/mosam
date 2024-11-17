import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        long s = 0;
        long ans = 0;
        for (int i=0; i<a; i++){
            s += in.nextInt()*2-1;
            ans += s;
        }
        System.out.println(ans);
    }
}