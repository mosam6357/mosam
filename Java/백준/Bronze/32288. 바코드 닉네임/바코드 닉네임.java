import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int q = in.nextInt();
        String a = in.next().replace("I","i");
        System.out.println(a.replace("l","L"));
    }
}