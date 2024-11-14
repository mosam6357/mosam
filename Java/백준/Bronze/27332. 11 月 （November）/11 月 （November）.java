import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt()+in.nextInt()*7;
        System.out.println(a>30?0:1);
    }
}