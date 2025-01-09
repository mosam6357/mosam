import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        while(true){
            int a = in.nextInt();
            if (a==-1){break;}
            int s = 0;
            int ans = 0;
            for (int i=0;i<a;i++){
                int b = in.nextInt();
                int c = in.nextInt();
                ans += b*(c-s);
                s += c-s;
            }
            System.out.printf("%d miles\n",ans);
        }
    }
}