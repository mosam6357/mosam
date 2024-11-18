import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        String[] a = in.nextLine().split("/");
        int b = Integer.parseInt(a[0]);
        int c = Integer.parseInt(a[1]);
        if(b<=12 && c<=12){
            System.out.println("either");
        }
        else if(b>12){
            System.out.println("EU");
        }
        else{
            System.out.println("US");
        }
    }
}