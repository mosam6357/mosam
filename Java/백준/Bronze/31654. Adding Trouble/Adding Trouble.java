import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt(); int b = in.nextInt();
        if(in.nextInt()==a+b){
            System.out.println("correct!");
        }
        else{
            System.out.println("wrong!");
        }
    }
}