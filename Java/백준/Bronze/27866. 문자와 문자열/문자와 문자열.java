import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        String i = in.nextLine();
        int a = in.nextInt();
        System.out.println(i.charAt(a-1));
    }
}