import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int t = in.nextInt();
        int s = 0;
        for (int i=0; i<t; i++){
            int a = in.nextInt();
            int b = in.nextInt();
            int c = in.nextInt();
            if(a<b){s+=(b-a)*c;}
        }
        System.out.println(s);
    }
}