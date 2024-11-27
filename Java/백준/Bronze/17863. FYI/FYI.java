import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        String a = in.next();
        System.out.printf("%s",(a.charAt(0)=='5' && a.charAt(1)=='5' && a.charAt(2)=='5')?"YES":"NO");
    }
}