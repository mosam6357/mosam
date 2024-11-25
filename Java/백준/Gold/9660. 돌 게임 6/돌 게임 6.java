import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        long a = in.nextLong();
        if(a%7==0 || a%7==2){
            System.out.println("CY");
        }
        else{
            System.out.println("SK");
        }
    }
}