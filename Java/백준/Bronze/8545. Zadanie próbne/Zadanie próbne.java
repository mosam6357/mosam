import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        String a = in.next();
        System.out.printf("%c%c%c",a.charAt(2),a.charAt(1),a.charAt(0));
    }
}