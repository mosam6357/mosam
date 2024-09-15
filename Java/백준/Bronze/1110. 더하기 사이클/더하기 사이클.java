import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt(); int cnt = 0; int c=a;
        while(true){
            c=(c%10)*10+((c/10)+(c%10))%10;
            cnt++;
            if(a==c){
                break;
            }
        }
        System.out.println(cnt);
    }
}