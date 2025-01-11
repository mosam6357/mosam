import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        String s1 = in.next()+in.next();
        String s2 = in.next()+in.next();
        Long a = Long.parseLong(s1)+Long.parseLong(s2);
        System.out.println(a);
    }
}