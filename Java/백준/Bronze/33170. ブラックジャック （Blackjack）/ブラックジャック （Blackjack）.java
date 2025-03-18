import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt()+in.nextInt()+in.nextInt();
        a = a>21?0:1;
        System.out.println(a);
    }
}