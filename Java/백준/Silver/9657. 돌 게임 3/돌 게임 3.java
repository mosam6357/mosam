import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        String b = (a%7!=0 && a%7!=2)?"SK":"CY";
        System.out.println(b);
    }
}