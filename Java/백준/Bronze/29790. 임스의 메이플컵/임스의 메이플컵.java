import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int n = in.nextInt();
        int a = in.nextInt();
        int b = in.nextInt();
        if(n>=1000 && (a>=8000 || b>=260)){
            System.out.println("Very Good");
        }
        else{
            System.out.println(n>=1000?"Good":"Bad");
        }
    }
}