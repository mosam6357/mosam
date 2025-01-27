import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int b = in.nextInt();
        int c = in.nextInt();
        int d = in.nextInt();
        int ans = 0;
        if (b>a){
            ans=a*c+(b-a)*d;
        }
        else{
            ans=b*c; 
        }
        System.out.println(ans);
    }
}