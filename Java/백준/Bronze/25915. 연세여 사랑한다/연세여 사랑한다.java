import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = Math.abs((int)(in.next().charAt(0)-'I'))+84;
        System.out.println(a);
    }
}