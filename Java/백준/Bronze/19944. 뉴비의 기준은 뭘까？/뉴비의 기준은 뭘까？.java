import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int b = in.nextInt();
        if(b<=2){
            System.out.println("NEWBIE!");
        }
        else if(b<=a){
            System.out.println("OLDBIE!");
        }
        else{
            System.out.println("TLE!");
        }
    }
}