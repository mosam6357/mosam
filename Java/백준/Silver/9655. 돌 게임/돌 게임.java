import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        String b = (a%2==1)?"SK":"CY";
        System.out.println(b);
    }
}