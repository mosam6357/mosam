import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        String s = in.next();
        for (int i=0;i<s.length();i+=a){
            System.out.printf("%c",s.charAt(i));
        }
    }
}