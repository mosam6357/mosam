import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt(); int b = in.nextInt();
        if(a%b==0){
            System.out.println("Yes");
        }
        else{
            System.out.println("No");
        }
    }
}