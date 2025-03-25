import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int b = in.nextInt();
        int c = in.nextInt()-a;
        if (c%b==0 && c/b+1>0){
            System.out.println(c/b+1);
        }
        else{
            System.out.println("X");
        }
    }
}