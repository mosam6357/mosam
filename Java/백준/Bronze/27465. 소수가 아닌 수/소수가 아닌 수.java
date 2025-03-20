import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        if (a%2!=0){
            a++;
        }
        if (a==2){
            a=4;
        }
        System.out.println(a);
    }
}