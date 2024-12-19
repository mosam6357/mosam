import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int b = in.nextInt();
        String[] s = new String[b];
        for (int i=0; i<b; i++){
            s[i] = in.next();
        }
        System.out.println(b);
        for (int i=0; i<b; i++){
            System.out.println(s[i]);
        }
    }
}