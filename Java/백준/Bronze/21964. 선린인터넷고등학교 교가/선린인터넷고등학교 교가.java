import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int q = in.nextInt();
        System.out.println(in.next().substring(q-5));
    }
}