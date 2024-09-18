import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt(); int b = in.nextInt();
        if(a*100<b){
            System.out.println("No");
        }
        else{
            System.out.println("Yes");
        }
    }
}