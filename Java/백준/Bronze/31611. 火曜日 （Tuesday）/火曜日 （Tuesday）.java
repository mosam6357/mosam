import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        if(a%7==2){
            System.out.println(1);
        }
        else{
            System.out.println(0);
        }
    }
}