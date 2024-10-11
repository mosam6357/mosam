import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt(); int b=  in.nextInt();
        if(a<=50 && b<=10){
            System.out.println("White");
        }
        else if(b>30){
            System.out.println("Red");
        }
        else{
            System.out.println("Yellow");
        }
    }
}