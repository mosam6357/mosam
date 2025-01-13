import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt()*1000+in.nextInt()*10000;
        System.out.println(a);
    }
}