import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt()+in.nextInt()*2+in.nextInt()*3;
        System.out.println((a>=10)?"happy":"sad");
    }
}