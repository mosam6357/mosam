import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        if(a%3==1){
            System.out.println("U");
        }
        else if(a%3==2){
            System.out.println("O");
        }
        else{
            System.out.println("S");
        }
    }
}